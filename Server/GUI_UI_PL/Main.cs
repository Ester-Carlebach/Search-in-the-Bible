using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_UI_PL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        //פתיחת קובץ חיפוש 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.ShowDialog();
        }
        //פתיחת קובץ עיון
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Browse b = new Browse();
            b.ShowDialog();
        }
        //פתיחת קובץ גימטריה
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Gim g = new Gim();
            g.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
