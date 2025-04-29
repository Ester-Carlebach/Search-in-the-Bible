using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_UI_PL
{
    public partial class Gim : Form
    {
        public Gim()
        {
            InitializeComponent();
        }
        //שולח לפונקציות הגימטריה
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                int c = Convert.ToInt32(textBox1.Text);
                string ls = Bll_Services.Class1.Gimatria(c);
                textBox3.Text = ls;
            }
            else
            {
                textBox3.Text = Bll_Services.Class1.Gimatria(textBox2.Text);

            }

        }
        //מציג תיבת טקסט
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Gim_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
