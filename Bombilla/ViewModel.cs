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
    public class ViewModel
    {
        private Bombilla100 _bombilla;
        public Bombilla100 Bombilla
        {
            get { return _bombilla; }
            set
            {
                _bombilla = value;
            }
        }

        public ICommand EncenderCommand { get; set; }
        public ICommand ApagarCommand { get; set; }

        public ViewModel()
        {
            Bombilla = new Bombilla100();
            EncenderCommand = new RelayCommand(Encender);
            ApagarCommand = new RelayCommand(Apagar);
        }

        private void Encender()
        {
            Bombilla.IsOn = true;
        }

        private void Apagar()
        {
            Bombilla.IsOn = false;
        }
    }
}
