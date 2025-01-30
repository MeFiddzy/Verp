using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Proiect_Romana
{
    public partial class Joc : Form
    {
        Random rnd = new Random();
        private int t, nrint, nrintcur = 0, s = 0, m = 0, ms = 0, abcdnri=0, afnri=0, clsnri=0, changablenri, debugint = -1, debugintt = -1;
        public static int scor = 0;
        string exeD = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public Joc()
        {
            InitializeComponent();
            //tabControlI.Selecting += tabControlI_Selecting;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Joc_Load(object sender, EventArgs e)
        {
            scor = 0;
            using (StreamReader fin = new StreamReader(Path.Combine(exeD, "cont", "setari.txt")))
            {
                string line = fin.ReadLine();
                changablenri = Convert.ToInt32(line);                
            }
            timerS.Start();
            for (int i = 0; i < 10; i++) { 
                readABCD(i);
            }
            for (int i = 0; i < 10; i++)
            {
                readAF(i);
            }
            for (int i = 0; i < 10; i++)
            {
                readCSL(i);
            }
            ChangeTab(3);
        }

        private void dis()
        {
            nrintcur++;
            afisare();
            buttonABCD.Enabled = false;
            buttonAF.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        abcd[] x = new abcd[10];
        AF[] y = new AF[10];
        csl[] z = new csl[10];
        

        private void readABCD(int nri)
        {
            if (string.IsNullOrEmpty(exeD))
            {
                MessageBox.Show("Error: Could not determine the executing assembly directory.");
                return;
            }

            string fileN = Path.Combine(exeD, "cont", "abcd", "i" + nri.ToString() + ".txt");

            try
            {
                using (StreamReader fin = new StreamReader(fileN))
                {
                    x[nri] = new abcd();
                    x[nri].i = fin.ReadLine();
                    x[nri].a = fin.ReadLine();
                    x[nri].b = fin.ReadLine();
                    x[nri].c = fin.ReadLine();
                    x[nri].d = fin.ReadLine();
                    x[nri].rc = Convert.ToChar(fin.ReadLine());                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }
        private int r;
        private void readAF(int nri)
        {
            if (string.IsNullOrEmpty(exeD))
            {
                MessageBox.Show("Error: Could not determine the executing assembly directory.");
                return;
            }

            string fileN = Path.Combine(exeD, "cont", "af", "i" + nri.ToString() + ".txt");

            try
            {
                using (StreamReader fin = new StreamReader(fileN))
                {
                    y[nri] = new AF();
                    y[nri].i = fin.ReadLine();;
                    y[nri].rc = Convert.ToChar(fin.ReadLine());                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }
        private void readCSL(int nri)
        {
            if (string.IsNullOrEmpty(exeD))
            {
                MessageBox.Show("Error: Could not determine the executing assembly directory.");
                return;
            }

            string fileN = Path.Combine(exeD, "cont", "csl", "i" + nri.ToString() + ".txt");

            try
            {
                using (StreamReader fin = new StreamReader(fileN))
                {
                    z[nri] = new csl();
                    z[nri].i = fin.ReadLine();
                    z[nri].r1 = fin.ReadLine();
                    z[nri].r2 = fin.ReadLine();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }   

        private void buttonAF_Click(object sender, EventArgs e)
        {
            ChangeTab(0);
            t = 1;
            if (debugintt == -1)
            {
                nrint = rnd.Next(0, 10);
                while (y[nrint].ales == true)
                {
                    nrint = rnd.Next(0, 10);
                }
            }
            else if (debugintt == 2)
                nrint = debugint;
            y[nrint].ales = true;
            textBoxIn.Text = y[nrint].i;
            afnri++;
           dis();
        }

        private void panelABCD_Paint(object sender, PaintEventArgs e) { }

        private void button2_Click(object sender, EventArgs e) {
            ChangeTab(2);
            t = 3;
            if (debugintt == -1)
            {
                nrint = rnd.Next(0, 10);
                while (z[nrint].ales == true)
                {
                    nrint = rnd.Next(0, 10);
                }
            }
            else if (debugintt == 3)
                nrint = debugint;
            z[nrint].ales = true;
            textBoxIcls.Text = z[nrint].i;
            clsnri++;
            dis();
        }

        private void tabPage2_Click(object sender, EventArgs e) { }

        private void ChangeTab(int tabIndex)
        {
            tabControlI.Selecting -= tabControlI_Selecting;
            tabControlI.SelectedIndex = tabIndex;
            tabControlI.Selecting += tabControlI_Selecting;
        }

        private void tabControlI_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (e.Action == TabControlAction.Selecting)
            //{
               // e.Cancel = true;
           // }
        }

        private void textBoxL2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxL1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelT2_Click(object sender, EventArgs e)
        {

        }

        private void labelT1_Click(object sender, EventArgs e)
        {

        }
        private void disinvers()
        {
            buttonABCD.Enabled = true;
            buttonAF.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void afisare()
        {
            labelS.Text = "Scor: " + scor;
            labelNrI.Text = "Număr Întrebare: " + nrintcur;
        }

        public static int msc;

        private void button3_Click(object sender, EventArgs e)
        {
            bool gata = false;
            if (nrintcur == changablenri)
            {
                gata = true;
            }
            if (t == 1)
            {
                if ((y[nrint].rc == 'A' && r == -1) || (y[nrint].rc == 'F' && r == 0))
                {
                    scor++;
                    disinvers();
                    ChangeTab(3);

                }
                else
                {
                    MessageBox.Show("Ai greșit! :(");
                    disinvers();
                    ChangeTab(3);
                }
            }
            else if (t == 2) {
                if ((x[nrint].rc == 'a' && r == 1) || (x[nrint].rc == 'b' && r == 2) || (x[nrint].rc == 'c' && r == 3) || (x[nrint].rc == 'd' && r == 4))
                {
                    scor++;
                    disinvers();
                    ChangeTab(3);

                }
                else
                {
                    MessageBox.Show("Ai greșit! :(");
                    disinvers();
                    ChangeTab(3);
                }
            }
            else
            {
                
                if (string.Equals(z[nrint].r1,textBoxL1.Text,StringComparison.OrdinalIgnoreCase) || string.Equals(z[nrint].r2, textBoxL2.Text, StringComparison.OrdinalIgnoreCase))
                {
                    scor++;
                    disinvers();
                    ChangeTab(3);

                }
                else
                {
                    MessageBox.Show("Ai greșit! :(");
                    disinvers();
                    ChangeTab(3);
                }
                textBoxL1.Text = string.Empty;
                textBoxL2.Text = string.Empty;
            } 
            if (gata == true)
            {
                string times, scores;
                using (StreamReader fin = new StreamReader(Path.Combine(exeD, "cont", "high_score.txt")))
                {
                    times = fin.ReadLine();
                    scores = fin.ReadLine();
                }
                int time = Convert.ToInt32(times);
                int score = Convert.ToInt32(scores);
                msc = ms + s * 100 + m * 60000;
                using (StreamWriter fout = new StreamWriter(Path.Combine(exeD, "cont", "high_score.txt")))
                {
                    if (time > msc && scor >= score)
                        fout.WriteLine(msc.ToString());
                    else if (scor > score)
                        fout.WriteLine(msc);
                    else
                        fout.WriteLine(times);
                    if (scor > score)
                        fout.WriteLine(scor.ToString());
                    else
                        fout.WriteLine(scores);
                }
                timerS.Stop();
                JocFinalizat jf = new JocFinalizat(m, s, ms, scor);
                jf.Show();
                dis();
                button3.Enabled = false;
            }
            afisare();
        }

        private void buttonABCD_Click(object sender, EventArgs e)
        {
            abcdnri++;
            ChangeTab(1);
            if (debugintt == -1)
            {
                t = 2;
                nrint = rnd.Next(0, 10);
                while (x[nrint].ales == true)
                {
                    nrint = rnd.Next(0, 10);
                }
            }
            else if (debugintt == 1)
            {
                nrint = debugint;
            }
            x[nrint].ales = true;
            textBoxI.Text = x[nrint].i;
            buttonA.Text = x[nrint].a;
            buttonB.Text = x[nrint].b;
            buttonC.Text = x[nrint].c;
            buttonD.Text = x[nrint].d;
            dis();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            r = 1;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            r = 2;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            r = 3;
        }

        private void panelinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerS_Tick(object sender, EventArgs e)
        {
            if (abcdnri == 10)
            {
                buttonABCD.Enabled = false;
                buttonABCD.BackColor = System.Drawing.Color.FromArgb(
                    75,
                    buttonABCD.BackColor.R,
                    buttonABCD.BackColor.G,
                    buttonABCD.BackColor.B);
            }
            if (afnri == 10)
            {
                buttonAF.Enabled = false;
                buttonAF.BackColor = System.Drawing.Color.FromArgb(
                    75,
                    buttonAF.BackColor.R,
                    buttonAF.BackColor.G,
                    buttonABCD.BackColor.B);
            }
            if (clsnri == 10)
            {
                button2.Enabled = false;
                button2.BackColor = System.Drawing.Color.FromArgb(
                    75,
                    button2.BackColor.R,
                    button2.BackColor.G,
                    button2.BackColor.B);
            }
            ms = ms + 1;
            if (ms == 100)
            {
                ms = 0;
                s++;
            }
            if(s == 60)
            {
                s = 0;
                m++;
            }
            string mt, st, mst;
            if (m < 10)
            {
                mt = "0" + m;
            }
            else
                mt = m.ToString();
            if (s < 10)
            {
                st = "0" + s;
            }
            else
                st = s.ToString();
            if (ms < 10)
            {
                mst = "0" + ms;
            }
            else
                mst = ms.ToString();
            labelT.Text = "Timp: " + mt + ':' + st + ':' + mst;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            r = 4;
        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            r = -1;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            r = 0;
        }
    }
}
