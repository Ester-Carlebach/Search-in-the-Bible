using Bll_Services;
using Da_Repository;
using DTO_Common_Enteties;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GUI_UI_PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        //הצגת כפתור הקלט של הספר
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        //- מפעיל פונקצית חיפוש
        //בתחילה הפעיל את הפונקציה שממלאה נתונים
        private void button1_Click_1(object sender, EventArgs e)
        {
            //ע"מ להפוך לגיסון
            //Bll_Services.Class1.fillData();
            //Sefer[] ls = new Sefer[24];
            //ls = Bll_Services.Class1.sfarimTanach;
            //List<Location> l = new List<Location>();
            //l = Bll_Services.Class1.LocationPasuk;
            //Json.ToJson(l);
            //Json.ToJson(ls);
            //Dictionary<Char, int> d = Bll_Services.Class1.Letters;
            //Json.ToJson(d);
            string word = wordToSearch.Text;
            string book = textBox1.Text;
            int count = 0;
            List<string> s = Bll_Services.Class1.search1(word, book, out count);
            l1.DataSource = s;
            textBox2.Text = " במערכת נמצאו  " + count.ToString() + " תוצאות    ";
        }


        private void l1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}