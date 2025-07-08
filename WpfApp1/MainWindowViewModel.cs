using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfApp1
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            PersonObj = new Person { FirstName = "Deepak", LastName = "Sharma", Gender = "Male", IsAvailable = true, IsSelected = true, IsShowHighLight = true };

            SaveCommand = new RelayCommand(ExecuteSave, CanExecuteSave);

            //try
            //{
            //    CauseError();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Final Handler StackTrace:");
            //    MessageBox.Show(ex.StackTrace);
            //}

           


        }



        public Person PersonObj
        {
            get;
            set;
        }

        public ICommand SaveCommand { get; }
        private async void ExecuteSave(object parameter)
        {
            await Task<bool>.Run(() => this.SaveInDB())
            .ContinueWith(UpDateUI, TaskScheduler.FromCurrentSynchronizationContext());

            await Task<bool>.Run(() => this.SaveInDB()).ContinueWith(UpDateUI, TaskScheduler.FromCurrentSynchronizationContext());

        }


        public class Employee
        {
            public virtual void Display()
            {
                MessageBox.Show("Employee Display");
            }


        }

        public class Clerk : Employee
        {
            public new void Display()
            {
                MessageBox.Show("Clerk Display");
            }

        }


        static void CauseError()
        {
            try
            {
                int x = 0;
                int y = 5 / x; // Line A
            }
            catch (Exception ex)
            {
                throw; // Line B
            }
        }



        private bool SaveInDB()
        {
            //save in db
            return true;
        }

        private void UpDateUI(Task<bool> tresult)
        {
            var result = tresult.Result;

            if (result)
            {
                Dispatcher.CurrentDispatcher.Invoke((Action)(() =>
                {
                    PersonObj.FirstName = "Samsung!!!";
                }));
            }
        }






        private bool CanExecuteSave(object parameter)
        {
            if (PersonObj.FirstName != "Deepak")
            {
                return false;
            }
            else
            {
                return true;
            }

            //  return true;
        }

    }

    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string lastname;
        public string FirstName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnpropertyChanged(FirstName);
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                OnpropertyChanged(LastName);
            }

        }

        private List<string> subjects;
        public List<string> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
                //OnpropertyChanged(LastName);
            }

        }

        private string _gender;
        public string Gender
        {
            get => _gender;
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    OnpropertyChanged(Gender);
                }
            }
        }

        public bool IsAvailable
        {
            get;
            set;
        }
        public bool IsSelected
        {
            get;
            set;
        }

        //public bool IsShowHighLight => IsAvailable && IsSelected;
        private bool isShowHighLight;
        public bool IsShowHighLight
        {
            get
            {
                return isShowHighLight;
            }
            set
            {
                isShowHighLight = value;
                OnpropertyChanged(nameof(IsShowHighLight));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        public string DepartMent;
        
        private string name;
        public decimal? Salary;
        public List<string> Subjects;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string name)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }




    public sealed class TREKLogger
    {
        private static TREKLogger instance = null;
        public static readonly object _lock = new object();

        private TREKLogger()
        {
        }

        public static TREKLogger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                        return instance = new TREKLogger();
                    return instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

    }

    public sealed class Logger
    {
        public static Logger instance = null;
        public static readonly object _lock = new object();

        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }
    }



}
