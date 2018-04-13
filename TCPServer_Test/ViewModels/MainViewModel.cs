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

        public string StateText
        {
            get { return _stateText; }
            set { _stateText = value; this.NotifyPropertyChanged("StateText"); }
        }

        private string _inputText;

        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; this.NotifyPropertyChanged("InputText"); }
        }

        public void ClickHandler()
        {
            if (String.IsNullOrEmpty(InputText))
            {
                StateText = "IP non inserido";
            }
            else
            {
                StateText = "IP inserido";
            }
        }

        public MainViewModel()
        {
            _stateText = "IP non inserido";
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
