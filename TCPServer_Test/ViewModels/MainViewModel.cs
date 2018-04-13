using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer_Test.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _stateText;
        private bool state;

        public string StateText
        {
            get { return _stateText; }
            set { _stateText = value; this.NotifyPropertyChanged("StateText"); }
        }

        public void ClickHandler()
        {
            state = !state;
            StateText = (state) ? "Piru grande" : "Piru pequeno";
        }

        public MainViewModel()
        {
            state = false;
            _stateText = "piru pequeno";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
