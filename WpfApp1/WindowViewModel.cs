using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public  class WindowViewModel: INotifyPropertyChanged
    {
        public WindowViewModel()
        {
            this.PersonObj = new Person { FirstName = "deepak" };
        }

        private Person person;
        public Person PersonObj
        {
            get 
            {
                return person;
            }
            set 
            {
                person = value;
                OnPropertyChanged(nameof(PersonObj));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));

  
        }
    }
}
