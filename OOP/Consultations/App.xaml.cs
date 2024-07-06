using Consultations.Models;
using Consultations.ViewModels;
using Consultations.Views;
using System.Windows;

namespace Consultations
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        List<Teacher> teachers = new List<Teacher>();
        List<Student> students = new List<Student>();
        private MainVM vm;

        private void OnStartup(object sender, StartupEventArgs e)
        {
            /*            using (Context db = new Context())
                        {
                            teachers = db.Teachers.Include(t => t.Students).ToList<Teacher>();
                            students = db.Students.Include(s => s.Teachers).ToList<Student>();
                        }*/

            MainWindow view = new MainWindow(); // создали View
            vm = new MainVM(); // Создали ViewModel
            view.DataContext = vm; // положили ViewModel во View в качестве DataContext
            view.Show();
        }

        private void OnExit(object sender, EventArgs e)
        {
            vm.unitOfWork.Save();
        }
    }
}
