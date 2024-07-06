using Consultations.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Consultations.Models
{
    public class Student : ViewModelBase
    {
        public Guid Id { get; set; }

        [Required]
        private string name;

        [Required]

        private int course;

        private int group;

        private ObservableCollection<Teacher> teachers = new ObservableCollection<Teacher>();

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Course
        {
            get { return course; }
            set
            {
                course = value;
                OnPropertyChanged(nameof(Course));
            }
        }
        public int Group
        {
            get { return group; }
            set
            {
                group = value;
                OnPropertyChanged(nameof(Group));
            }
        }

        public ObservableCollection<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
                OnPropertyChanged(nameof(Teachers));
            }
        }

    }
}
