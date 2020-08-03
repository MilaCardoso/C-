using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Finish_Mouse_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("You Won!!!");
        }

        private void Start_Mouse_Enter(object sender, EventArgs e)
        {
            Point startPoint = panel1.Location;
            Cursor.Position = PointToScreen(startPoint);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Camila\Downloads\error.wav");
            player.Play();

        }
    }
}
