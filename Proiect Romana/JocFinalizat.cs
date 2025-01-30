using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Romana
{
    public partial class JocFinalizat : Form
    {
        private int m, s, ms, scor;
        public JocFinalizat(int ml, int sl, int msl, int scorl)
        {
            InitializeComponent();
            m = ml;
            s = sl;
            ms = msl;
            scor = scorl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {

        }

        string exeD = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        int mm, sm, msm;

        private void decode(int mscomb)
        {
            int r = mscomb % 60000;
            mm = mscomb / 60000;
            sm = r / 100;
            msm = r % 100;
        }

        private void JocFinalizat_Load(object sender, EventArgs e)
        {
            string times, scores;
            using (StreamReader fin = new StreamReader(Path.Combine(exeD, "cont", "high_score.txt")))
            {
                times = fin.ReadLine();
                scores = fin.ReadLine();
            }
            int time = Convert.ToInt32(times);
            int score = Convert.ToInt32(scores);

            decode(time);

            textBoxSM.Text = "Scor Maxim: " + score;

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
            ///--------------------
            string mtm, stm, mstm;
            if (m < 10)
            {
                mtm = "0" + mm;
            }
            else
                mtm = mm.ToString();
            if (sm < 10)
            {
                stm = "0" + sm;
            }
            else
                stm = s.ToString();
            if (msm < 10)
            {
                mstm = "0" + msm;
            }
            else
                mstm = msm.ToString();

            textBoxMT.Text = "Timp Maxim: " + mtm + ':' + stm + ':' + mstm;

            textBoxT.Text = "Timp: " + mt + ':' + st + ':' + mst;
            textBoxS.Text = "Scor: " + scor;
        }
    }
}
