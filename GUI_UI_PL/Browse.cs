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
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }
        //שליחה לפונקציה המחזירה את הפרק המבוקש
        private void button1_Click(object sender, EventArgs e)
        {
            string book = this.book.Text;
            string perek = this.perek.Text;
            textBox1.Text = Bll_Services.Class1.Browse1(book, perek); ;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
