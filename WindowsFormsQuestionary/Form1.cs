using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsQuestionary
{
    public partial class Form1 : Form
    {
        int numOFQ = 0;
        int numOFA = 0;
        string fileName;
        Question storage;
        public Form1()
        {
            InitializeComponent();
        }

        public void fProgress(int num, int size)
        {
            int fixSize = progressBar1.Maximum;
            int bNum = size;
            int progress = ((fixSize * num) / bNum);

            progressBar1.Value = progress;
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                storage = new Question();
                fileName = openFileDialog1.FileName;
                foreach (var line in File.ReadLines(fileName))
                {
                    storage.AddQuestion(line);
                    numOFQ++;
                }
                btn_start.Visible = true;
            }
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            List<string> q = storage.ReadQuestionAll();
            if (numOFA < q.Count)
            {
                txb_question.Text = q[numOFA];
                numOFA++;
            } else
            {
                txb_question.Clear();
                txb_answer.ReadOnly = true;
                btn_finish.Visible = true;
            }

        }

        private void txb_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                storage.AddAnswer($"Q{ numOFA}#A{numOFA}=" + txb_answer.Text);
                txb_answer.Clear();
                fProgress(numOFA, numOFQ);
                btn_start.PerformClick();
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            var x = File.Create("answeres.txt");
            x.Close();
            File.AppendAllLines("answeres.txt", storage.ReadAnswersAll());
            Environment.Exit(0);
        }

    }
}
