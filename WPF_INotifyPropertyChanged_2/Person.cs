using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotifyPropertyChanged_2
{
    public class Person : INotifyPropertyChanged
    {
        //implement INotify - delegate and event
        public event PropertyChangedEventHandler PropertyChanged;

        //private variables
        string firstName = "Bob";
        string lastName = "Gromit";

        //public properties
        public string FirstName
        {
            get
            { return firstName; }

            set
            {
                firstName = value;
                OnPropertyChanged("Surname");
            }
        }

        public string LastName
        {
            get
            { return lastName; }

            set
            {
                lastName = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Surname
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName); }
        }
    


        private void OnPropertyChanged(string property)
        {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
    
}
