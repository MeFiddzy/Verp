using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Proiect_Romana
{
    public partial class Settings : Form
    {
        string exeD = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private int m, s, ms, scor;
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ești sigur ca vrei să resetezi scorul și timpul maxim al tău?", "Atenție!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StreamWriter fout = new StreamWriter(Path.Combine(exeD, "cont", "high_score.txt")))
                {
                    fout.WriteLine("2147483647");
                    fout.WriteLine("-1");
                    MessageBox.Show("Scor și timp maxim resetat!", "Confirmare");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter fout = new StreamWriter(Path.Combine(exeD, "cont", "setari.txt")))
            {
                fout.WriteLine(textBoxINT.Text);
                MessageBox.Show("Numărul de întrebari joc setat la " + textBoxINT.Text + " întrebări.", "Confirmare");
            }
        }

        private void decode(int mscomb)
        {
            int r = mscomb % 60000;
            m = mscomb / 60000;
            s = r / 100;
            ms = r % 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string times, scores;
            using (StreamReader fin = new StreamReader(Path.Combine(exeD, "cont", "high_score.txt")))
            {
                times = fin.ReadLine();
                scores = fin.ReadLine();
            }

            bool error = false;

            while (times == "2147483647" || scores == "-1")
            {
                error = true;
                if (MessageBox.Show("Timpul a fost resetat recent sau nu a fost inițializat!", "Eroare!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    break;
                }
            }

            if (error == true)
                return;

            int time = Convert.ToInt32(times);

            decode(time);

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
            MessageBox.Show("Timp maxim: " + mt + ':' + st + ':' + mst + "\n Scorul maxim: " + scores, "Scor & Timp maxim");
        }
    }
}
