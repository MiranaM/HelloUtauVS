using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUtauVS
{
    public partial class samplePlug : Form
    {
        private string[] args;

        public samplePlug()
        {
            InitializeComponent();
            args = Environment.GetCommandLineArgs();

        }

        private void samplePlug_Load(object sender, EventArgs e)
        {
            textBox1.Lines = args;             
            
            
        }
    }
}
