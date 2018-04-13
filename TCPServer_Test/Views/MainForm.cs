using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPServer_Test
{
    public partial class MainForm : Form
    {
        private ViewModels.MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();

            _viewModel = new ViewModels.MainViewModel();

            btnClick.Click += BtnClick_Click;

            this.lbState.DataBindings.Add("Text", _viewModel, "StateText");

            this.tbInput.DataBindings.Add("Text", _viewModel, "InputText");
            
        }


        private void BtnClick_Click(object sender, EventArgs e)
        {
            _viewModel.ClickHandler();
        }
    }
}
