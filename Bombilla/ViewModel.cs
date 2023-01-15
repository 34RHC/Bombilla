using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Bombilla;

namespace Bombilla
{
    public class ViewModel : INotifyPropertyChanged
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

        public ICommand EncenderCommand { get; set; }
        public ICommand ApagarCommand { get; set; }

        public ViewModel()
        {
            EncenderCommand = new RelayCommand(Encender);
            ApagarCommand = new RelayCommand(Apagar);
        }

        private void Encender()
        {
            IsOn = true;
        }

        private void Apagar()
        {
            IsOn = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
