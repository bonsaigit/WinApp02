using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void globalVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVarForm f = new GlobalVarForm();
            f.ShowDialog();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionform f = new connectionform();
            f.ShowDialog();
        }
        private string getcompanyname()
        {
            return "PNK Co., Ltd.";
        }
    }
}
