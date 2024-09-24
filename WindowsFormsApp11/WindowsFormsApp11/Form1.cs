using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int cc = (int)numericUpDown1.Value;
            MessageBox.Show("Ahoj");
        }
    }
}
