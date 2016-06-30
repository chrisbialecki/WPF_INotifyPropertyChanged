using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotifyPropertyChanged_3
{
    public class BoundValueModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _boundValue = "start-up bound value";

        public string BoundValue
        {
            get { return _boundValue; }
            set
            {
                _boundValue = value;
                OnPropertyChanged("BoundValue");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
