using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Romana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            Teorie t = new Teorie();
            t.Show();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            Joc j = new Joc();
            j.Show();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }
    }
}
