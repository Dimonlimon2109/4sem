using Consultations.Models;
using System.Collections.ObjectModel;

namespace Consultations.ViewModels
{
    public class MainVM : ViewModelBase
    {
        public ObservableCollection<Teacher> ConsultationsList { get; set; }
        public ObservableCollection<Student> StudentsList { get; set; }

        private Student creatingStudent = new Student();

        private Context context;

        private UnitOfWork _unitOfWork;

        private IEnumerable<Student> studentsWithTeachers;


        private IEnumerable<Teacher> teachersWithStudents;
        public UnitOfWork unitOfWork
        {
            get { return _unitOfWork; }
            set
            {
                _unitOfWork = value;
            }
        }
        public Student CreatingStudent
        {
            get { return creatingStudent; }
            set
            {
                creatingStudent = value;
                OnPropertyChanged(nameof(CreatingStudent));
            }
        }


        private Teacher creatingTeacher = new Teacher();

        public Teacher CreatingTeacher
        {
            get { return creatingTeacher; }
            set
            {
                creatingTeacher = value;
                OnPropertyChanged(nameof(CreatingTeacher));
            }
        }


        public MainVM()
        {
            _unitOfWork = new UnitOfWork(new Context());
            studentsWithTeachers = unitOfWork.Repository<Student>().GetAllWithInclude("Teachers");
            teachersWithStudents = unitOfWork.Repository<Teacher>().GetAllWithInclude("Students");
            ConsultationsList = new ObservableCollection<Teacher>(teachersWithStudents.Select(b => b));
            StudentsList = new ObservableCollection<Student>(studentsWithTeachers.Select(b => b));
        }
        private Teacher _selectedTeacher;
        public Teacher SelectedTeacher
        {
            get { return _selectedTeacher; }
            set
            {
                _selectedTeacher = value;
                OnPropertyChanged(nameof(SelectedTeacher));
            }
        }

        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }

        private RelayCommand deleteStudent;

        public RelayCommand DeleteStudent
        {
            get
            {
                return deleteStudent ?? (
                    deleteStudent = new RelayCommand(obj =>
                    {
                        foreach (var teacher in ConsultationsList)
                        {
                            foreach (var student in teacher.Students)
                            {
                                if (SelectedStudent == student)
                                {
                                    teacher.Students.Remove(student);
                                    break;
                                }
                            }
                        }
                        unitOfWork.Repository<Student>().Remove(SelectedStudent);
                        StudentsList.Remove(SelectedStudent);
                        unitOfWork.Save();
                    }, (_) =>
                    {
                        return SelectedStudent != null;
                    }));
            }
        }

        private RelayCommand deleteTeacher;

        public RelayCommand DeleteTeacher
        {
            get
            {
                return deleteTeacher ?? (
                    deleteTeacher = new RelayCommand(obj =>
                    {
                        foreach (var student in StudentsList)
                        {
                            foreach (var teacher in student.Teachers)
                            {
                                if (SelectedTeacher == teacher)
                                {
                                    student.Teachers.Remove(teacher);
                                    break;
                                }
                            }
                        }
                        unitOfWork.Repository<Teacher>().Remove(SelectedTeacher);
                        ConsultationsList.Remove(SelectedTeacher);
                        unitOfWork.Save();
                    }, (_) =>
                    {
                        return SelectedTeacher != null;
                    }));
            }
        }

        private RelayCommand record;
        public RelayCommand Record
        {
            get
            {
                return record ?? (
                    new RelayCommand(obj =>
                    {
                        SelectedStudent.Teachers.Add(SelectedTeacher);
                        SelectedTeacher.Students.Add(SelectedStudent);
                        unitOfWork.Save();
                    }, (_) =>
                    {
                        return SelectedStudent != null && SelectedTeacher != null && !SelectedTeacher.Students.Contains(SelectedStudent);
                    }));
            }
        }

        private RelayCommand cancel;

        public RelayCommand Cancel
        {
            get
            {
                return cancel ?? (
                    new RelayCommand(obj =>
                    {
                        SelectedStudent.Teachers.Remove(SelectedTeacher);
                        SelectedTeacher.Students.Remove(SelectedStudent);
                        unitOfWork.Save();
                    }, (_) =>
                    {
                        return SelectedStudent != null && SelectedTeacher != null && SelectedTeacher.Students.Contains(SelectedStudent);
                    }));
            }
        }

        private RelayCommand addStudent;

        public RelayCommand AddStudent
        {
            get
            {
                return addStudent ?? (
                    (addStudent = new RelayCommand(obj =>
                    {
                        unitOfWork.Repository<Student>().Add(CreatingStudent);
                        StudentsList.Add(CreatingStudent);
                        unitOfWork.Save();
                        CreatingStudent = new Student();
                    }

                    )));
            }
        }

        private RelayCommand addTeacher;

        public RelayCommand AddTeacher
        {
            get
            {
                return addTeacher ?? (
                    (addTeacher = new RelayCommand(obj =>
                    {
                        unitOfWork.Repository<Teacher>().Add(CreatingTeacher);
                        ConsultationsList.Add(CreatingTeacher);
                        unitOfWork.Save();
                        CreatingTeacher = new Teacher();
                    }

                    )));
            }
        }
    }
}
