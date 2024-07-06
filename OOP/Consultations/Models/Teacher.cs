using Consultations.ViewModels;
using System.Collections.ObjectModel;

namespace Consultations.Models
{
    public class Teacher : ViewModelBase
    {
        public Guid Id { get; set; }
        private string name;
        private string subject;
        private string time;
        private DateOnly date;
        private ObservableCollection<Student> students = new ObservableCollection<Student>();

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Subject
        {
            get { return subject; }
            set
            {
                subject = value;
                OnPropertyChanged("Subject");
            }
        }

        public string Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged("Time");
            }
        }

        public DateOnly Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }


        public ObservableCollection<Student> Students
        {
            get { return students; }
            set
            {
                students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

    }
}
