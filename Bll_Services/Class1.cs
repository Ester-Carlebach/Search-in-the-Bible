using DTO_Common_Enteties;
using System.Threading.Tasks;
//הערה בשורה 132
namespace Bll_Services
{
    public class Class1
    {
        //טקסט התנך
        public static string Tora = Da_Repository.Class1.AllTanach();
        //כל הספרים
        public static Sefer[] sfarimTanach;
        //כל המיקומים
        public static List<Location> LocationPasuk;
        //Dictionary המפתח אות והערך הגימטריה של האות
        public static Dictionary<Char, int> Letters = new Dictionary<Char, int>();

        static Class1()
        {
            //הצבה בליסט הספרים את ההמרה שלהם מגיסון
            sfarimTanach = Da_Repository.Json.FromJson();
            ////הצבה בליסט המיקומים את ההמרה שלהם מגיסון
            LocationPasuk = Da_Repository.Json.FromJson1();
            ////הצבה בדיכטיונרי  את ההמרה שלו מגיסון
            Letters = Da_Repository.Json.FromJson2();
        }
        public static void fillData()
        {
            //מילוי האותיות וערכן
            //  Letters.Add('א', 1);
            //  Letters.Add('ב', 2);
            //  Letters.Add('ג', 3);
            //  Letters.Add('ד', 4);
            //  Letters.Add('ה', 5);
            //  Letters.Add('ו', 6);
            //  Letters.Add('ז', 7);
            //  Letters.Add('ח', 8);
            //  Letters.Add('ט', 9);
            //  Letters.Add('י', 10);
            //  Letters.Add('כ', 20);
            //  Letters.Add('ך', 20);
            //  Letters.Add('ל', 30);
            //  Letters.Add('מ', 40);
            //  Letters.Add('ם', 40);
            //  Letters.Add('נ', 50);
            //  Letters.Add('ן', 501);
            //  Letters.Add('ס', 60);
            //  Letters.Add('ע', 70);
            //  Letters.Add('פ', 80);
            //  Letters.Add('ף', 80);
            //  Letters.Add('צ', 90);
            //  Letters.Add('ץ', 90);
            //  Letters.Add('ק', 100);
            //  Letters.Add('ר', 200);
            //  Letters.Add('ש', 300);
            //  Letters.Add('ת', 400);

            ////  Jsonמילוי הספרים לפני ההפיכה ל
            LocationPasuk = new List<Location>();
            //מערך הספרים
            sfarimTanach = new Sefer[24];
            string[] sfarim = Tora.Split('$');
            for (int i = 1; i < sfarim.Length; i++)
            {
                sfarimTanach[i - 1] = new Sefer();
                sfarimTanach[i - 1].Text = sfarim[i - 1];
                sfarimTanach[i - 1].Text.Substring(sfarimTanach[i - 1].Text.IndexOf('~') + 2);
                sfarimTanach[i - 1].SeferName = sfarim[i].Substring(sfarim[i].IndexOf("^ פרשת ") + 7, sfarim[i].IndexOf("~") - 11);

                string[] prakim = sfarim[i].Split("~");
                for (int j = 1; j < prakim.Length; j++)
                {
                    {
                        Perek p = new Perek();
                        if (!(i == 0 && j == 0))
                        {
                            p.Text = prakim[j];
                            p.NamePerek = prakim[j].Substring(prakim[j].IndexOf("-") + 1);
                            p.NamePerek = p.NamePerek.Substring(0, 2);
                            if (p.NamePerek[1] == '\r')
                                p.NamePerek = p.NamePerek.Substring(0, 1);
                        }

                        sfarimTanach[i - 1].PerekList.Add(p);
                        string[] psukim = prakim[j].Split("!");
                        for (int l = 1; l < psukim.Length; l++)
                        {
                            Pasuk p1 = new Pasuk();
                            p1.Text = psukim[l];
                            p1.PasukName = psukim[l][2].ToString();
                            if (psukim[l][3] != '}')
                                p1.PasukName += psukim[l][3].ToString();
                            sfarimTanach[i - 1].PerekList[j - 1].Psukim.Add(p1);
                            int g = 0;
                            string t = sfarimTanach[i - 1].PerekList[j - 1].Psukim[l - 1].Text;
                            for (int k = 0; k < t.Length; k++) 
                            {
                                Char c = t[k];
                                if (t[k] != ':' && t[k] != ' ' && t[k] != '^' && t[k] != '{' && t[k] != '}' && t[k] != '\r' && t[k] != '\n')
                                {
                                    g += Letters[c];
                                }
                            }
                            t = sfarimTanach[i - 1].PerekList[j - 1].Psukim[l - 1].PasukName;
                            for (int k = 0; k < t.Length; k++)
                            {
                                g -= Letters[t[k]];
                            }

                            Location loc = new Location(g, sfarimTanach[i - 1].SeferName, sfarimTanach[i - 1].PerekList[j - 1].NamePerek,
                                sfarimTanach[i - 1].PerekList[j - 1].Psukim[l - 1].PasukName, sfarimTanach[i - 1].PerekList[j - 1].Psukim[l - 1].Text);
                            LocationPasuk.Add(loc);

                        }
                    }
                }
            }
        }
        //חיפוש ע"פ המיקומים
        public static List<string> search1(string word, string book, out int count)
        {
            count = 0;
                book = book + "\r";
            List<string> strings = new List<string>();
            for (int i = 0; i < LocationPasuk.Count; i++)
            {
                string pasuk = LocationPasuk[i].Text;
                //אינדקס תחילת המילה
                int ind = pasuk.IndexOf(word);
                //אינדקס סוף המילה
                int lastInd = ind + word.Length;
                //בדיקה אם המילה היא מילה בפני עצמה
                //בשורה זו אני רוצה לבדוק אם הפסוק מכיל את המילה בשלמותה משום מה לא עובד 
               // if ((pasuk[lastInd] == ' ' || pasuk[lastInd] == '\r') && (ind == 6 || pasuk[ind - 1] == ' ') && ind != -1 && ("".Equals(book) || LocationPasuk[i].Sefer.Equals(book)))
                if(ind!=-1)
                {
                    strings.Add(" ");
                    //הוספת מיקום הפסוק
                    strings.Add(LocationPasuk[i].ToString());
                    //הוספת טקסט הפסוק
                    strings.Add(LocationPasuk[i].Text);
                    count++;
                    pasuk = pasuk.Substring(ind + 1);
                    ind = pasuk.IndexOf(word);
                    lastInd = ind + word.Length;
                    //המשך חיפוש כמה פעמים מופיעה המילה מופיעה בפסוק
                    while (ind != -1)
                    {
                        if (pasuk[ind - 1] == ' ' && pasuk[lastInd] == '\r' && pasuk[lastInd] == ' ')
                            count++;
                        pasuk = pasuk.Substring(ind + 1);
                        ind = pasuk.IndexOf(word);
                        lastInd = ind + word.Length;
                    }
                }


            }
            return strings;
        }



        //נח יותר ע"י הספרים

        public static string Browse1(string book, string perek)
        {

            book = book + "\r";
            if(perek.Length==1)
            perek = perek + "\r";

            string ls = "";
            for (int i = 0; i < LocationPasuk.Count; i++)
            {
                if (LocationPasuk[i].Sefer.Equals(book) && LocationPasuk[i].Perek.Equals(perek))
                    ls += "\n" + LocationPasuk[i].Text;
            }
            if (ls == "")
                return "אין נתונים במערכת על מיקום זה";
            return ls;
        }
        //גימטריה ע"פ מספר
        public static string Gimatria(int num)
        {
            string strings = "";
            for (int i = 0; i < LocationPasuk.Count; i++)
            {
                if (LocationPasuk[i].Gimatria == num)
                {
                    strings += LocationPasuk[i].ToString();
                    strings += LocationPasuk[i].Text;
                }

            }
            return strings;
        }
        //גימטריה ע"פ טקסט
        public static string Gimatria(string text)
        {

            int num = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '\n' && text[i] != '\r')
                    num += Letters[Convert.ToChar(text[i])];
            }
            string strings = "";
            for (int i = 0; i < LocationPasuk.Count; i++)
            {
                if (LocationPasuk[i].Gimatria == num)
                {
                    strings += LocationPasuk[i].ToString();
                    strings += LocationPasuk[i].Text;
                }

            }
            return strings;
        }
        public static void ToJson()
        {
            throw new NotImplementedException();
        }
        //נח יותר ע"י המיקומים
          public static List<string> search(string word, string book, out int count)
        {
            count = 0;
            List<Pasuk> listp = new List<Pasuk>();
            List<string> strings = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < sfarimTanach[i].PerekList.Count; j++)
                {
                    for (int k = 0; k < sfarimTanach[i].PerekList[j].Psukim.Count; k++)
                    {
                        string pasuk = sfarimTanach[i].PerekList[j].Psukim[k].Text;
                        int ind = pasuk.IndexOf(word);
                        int lastInd = ind + word.Length;
                        if (ind != -1 && (pasuk[lastInd] == ' ' || pasuk[lastInd] == '\r') && (ind == 6 || pasuk[ind - 1] == ' ') && (book == "" || sfarimTanach[i].SeferName.Equals(book)))
                        {
                            strings.Add(pasuk[lastInd].ToString());
                            strings.Add(sfarimTanach[i].SeferName + ", " + sfarimTanach[i].PerekList[j].NamePerek + ", " + sfarimTanach[i].PerekList[j].Psukim[k].PasukName);
                            strings.Add(sfarimTanach[i].PerekList[j].Psukim[k].ToString());
                            count++;
                            pasuk = pasuk.Substring(sfarimTanach[i].PerekList[j].Psukim[k].Text.IndexOf(word) + 1);
                            ind = pasuk.IndexOf(word);
                            lastInd = ind + word.Length;
                            while (pasuk.IndexOf(word) != -1)
                            {
                                if (pasuk[ind - 1] == ' ' && pasuk[lastInd] == '\r' && pasuk[lastInd] == ' ')
                                    count++;
                                pasuk = pasuk.Substring(pasuk.IndexOf(word) + 1);
                                ind = pasuk.IndexOf(word);
                                lastInd = ind + word.Length;
                            }
                        }
                    }
                }
            }
            return strings;
        }
        //פונקצית עיון ע"פ ספרים
        public static string Browse(string book, string perek)
        {
            book = book + "\r";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < sfarimTanach[i].PerekList.Count; j++)
                {
                    if (sfarimTanach[i].SeferName.Equals(book) && sfarimTanach[i].PerekList[j].NamePerek.Equals(perek))
                        return sfarimTanach[i].PerekList[j].Text;
                }

            }
            return "אין נתונים במערכת על מיקום זה";
        }
        //פונקציית חיפוש בסיסית
        public List<int> Index(string data, string word)
        {
            List<int> list = new List<int>();
            int i = 0;
            while (i < data.Length && data.IndexOf(word, i) != -1)
            {
                data.IndexOf(word, i);
                list.Add(data.IndexOf(word, i));
                i = data.IndexOf(word, i) + 1;
            }
            return list;
        }

    }

}
