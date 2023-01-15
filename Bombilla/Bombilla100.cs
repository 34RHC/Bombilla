using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombilla
{
    public class Bombilla100 : INotifyPropertyChanged
    {
        private bool _isOn;
        public bool IsOn
        {
            get { return _isOn; }
            set
            {
                _isOn = value;
                OnPropertyChanged("IsOn");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
