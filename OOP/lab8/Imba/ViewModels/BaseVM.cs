using Imba.Views;
using PCAtelier.Commands;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;


namespace Imba.ViewModels
{
    internal class BaseVM : INotifyPropertyChanged
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private SqlConnection _connection;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _commandBuilder;
        private DataSet _ds;

        private Object _mainWindow;
        private MainView _mainView = new MainView();
        public Object Window
        {
            get { return _mainWindow; }
            set { _mainWindow = value; }
        }

        public MainView MainView
        {
            get => _mainView;
        }

        private RelayCommand _add;
        public RelayCommand Add
        {
            get
            {
                return _add ?? (_add = new RelayCommand(
                    (_) =>
                    {
                        if (Window is MainWindow main)
                        {
                            _ds.Tables[0].Rows.Add(Guid.NewGuid().ToString());
                        }
                    }
                    ));
            }
        }

        private RelayCommand _up;
        public RelayCommand Up
        {
            get
            {
                return _up ?? (_up = new RelayCommand(
                    (_) =>
                    {
                        if (Window is MainWindow main)
                        {
                            MainView.dg.SelectedIndex += 1;
                        }
                    }
                    ));
            }
        }

        private RelayCommand _down;
        public RelayCommand Down
        {
            get
            {
                return _down ?? (_down = new RelayCommand(
                    (_) =>
                    {
                        if (MainView.dg.SelectedIndex != -1)
                            MainView.dg.SelectedIndex -= 1;
                    }));
            }
        }


        public BaseVM()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
                return;
            _connection = new SqlConnection(_connectionString);
            MainView.dg.AutoGeneratingColumn += (s, e) => { e.Column.Width = 100; };
            ReadData();
            MainView.dg.CanUserAddRows = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand _save;
        public RelayCommand Save
        {
            get
            {
                return _save ?? (
                    _save = new RelayCommand(
                        (_) =>
                        {
                            save();
                        }
                        ,
                        (_) => true
                        )
                    );
            }
        }

        private void save()
        {
            _connection.Open();

            SqlTransaction sqlTransaction = null;
            SqlTransaction sqlTransaction2 = null;


            try
            {
                _adapter = new SqlDataAdapter("select Users.UserId Id, Users.UserLogin Login, Users.UserPassword Password from Users", _connection);
                _commandBuilder = new SqlCommandBuilder(_adapter);
                _adapter.InsertCommand = new SqlCommand("sp_CreateUser", _connection);
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@login", SqlDbType.NVarChar, 50, "Login"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50, "Password"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 50, "Id"));
                _adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                _adapter.UpdateCommand = _commandBuilder.GetUpdateCommand();
                _adapter.DeleteCommand = _commandBuilder.GetDeleteCommand();
                sqlTransaction = _connection.BeginTransaction();
                _adapter.InsertCommand.Transaction = sqlTransaction;
                _adapter.UpdateCommand.Transaction = sqlTransaction;
                _adapter.DeleteCommand.Transaction = sqlTransaction;
                _adapter.Update(_ds.Copy());
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }
            }
            finally
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Dispose();
                }
            }
            try
            {
                _adapter = new SqlDataAdapter("select UserId Id, UserInfos.UserDescription Description, UserInfos.UserPhoto Photo, UserInfos.UserName Name from UserInfos", _connection);
                _commandBuilder = new SqlCommandBuilder(_adapter);
                _adapter.InsertCommand = new SqlCommand("sp_CreateUserInfo", _connection);
                _adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar, 50, "Id"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.NVarChar, 100, "Photo"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar, 50, "Description"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                _adapter.UpdateCommand = _commandBuilder.GetUpdateCommand();
                _adapter.DeleteCommand = _commandBuilder.GetDeleteCommand();
                sqlTransaction2 = _connection.BeginTransaction();
                _adapter.InsertCommand.Transaction = sqlTransaction2;
                _adapter.UpdateCommand.Transaction = sqlTransaction2;
                _adapter.DeleteCommand.Transaction = sqlTransaction2;
                _adapter.Update(_ds.Copy());
                sqlTransaction2.Commit();

            }
            catch (Exception ex)
            {
                    sqlTransaction2?.Rollback();
            }
            finally
            {
                if (sqlTransaction2 != null)
                {
                    sqlTransaction2.Dispose();
                }
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

            private void ReadData()
        {
            try
            {
                _connection.Open();
                SqlCommand sqlCommand = _connection.CreateCommand();
                sqlCommand.CommandText = "select Users.UserId Id, Users.UserLogin Login, Users.UserPassword Password, UserInfos.UserDescription Description, UserInfos.UserPhoto Photo, UserInfos.UserName Name from Users inner join UserInfos on UserInfos.UserId = Users.UserId";
                _adapter = new SqlDataAdapter(sqlCommand);
                _ds = new DataSet();
                _adapter.Fill(_ds);
                MainView.dg.ItemsSource = _ds.Tables[0].AsDataView();
            }
            catch (SqlException)
            {
                _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ReserveConnection"].ConnectionString);
                SqlCommand sql = new SqlCommand("create database lab8", _connection);
                _connection.Open();
                sql.ExecuteNonQuery();
                sql = new SqlCommand("USE [Lab8] CREATE TABLE [dbo].[Users]( [UserId] [nvarchar](50) NOT NULL primary key, [UserLogin] [nvarchar](50) NULL, [UserPassword] [nvarchar](50) NULL)", _connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand("USE [Lab8] CREATE TABLE [dbo].[UserInfos]( [UserId] [nvarchar](50) NOT NULL primary key, [UserPhoto] [nvarchar](100) NULL, [UserDescription] [nvarchar](50) NULL, [UserName] [nvarchar](50) NULL, )", _connection);
                sql.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show($"Перезапустите приложение");
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
