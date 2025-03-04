using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLCM_Inteos
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "LCM")
            {
                LCM lcmForm = new LCM();
                lcmForm.Show();
            }
            else if (e.Node.Name == "Wartungsaufgaben")
            {

            }


        }
    }
}
