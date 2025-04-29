using DTO_Common_Enteties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Da_Repository
{
    public class Json
    {
        //סרליזציה לספרים
        public static void ToJson(Sefer[] s)
        {
            string json = JsonConvert.SerializeObject(s);
            File.WriteAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Tanach.json", json);
            //File.WriteAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Tanach.json", json);

        }
        //סרליזציה לאותיות
        public static void ToJson(Dictionary<Char,int> let)
        {
            string json = JsonConvert.SerializeObject(let);
           File.WriteAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Letters.json", json);
           // File.WriteAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Letters.json", json);

        }
        //סרליזציה למיקומים
        public static void ToJson(List<Location> ll)
        {
            string json = JsonConvert.SerializeObject(ll);
             File.WriteAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Psukim.json", json);
           // File.WriteAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Psukim.json", json);

        }
        //דיסרליזציה לספרים
        public static Sefer[] FromJson()
        {
            string existingJson = File.ReadAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Tanach.json");
            //string existingJson = File.ReadAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Tanach.json");

            Sefer[] list = new Sefer[24];
            list = JsonConvert.DeserializeObject<Sefer[]>(existingJson);
            return list;
        }
        //דיסרליזציה למיקומים
        public static List<Location> FromJson1()
        {
            string existingJson = File.ReadAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Psukim.json");

           // string existingJson = File.ReadAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Psukim.json");

            List<Location> list = new List<Location>();
            list = JsonConvert.DeserializeObject<List<Location>>(existingJson);
            return list;
        }
        //דיסרליזציה לאותיות
        public static Dictionary<Char,int> FromJson2()
        {
            string existingJson = File.ReadAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Letters.json");

      //      string existingJson = File.ReadAllText("D:\\C#\\חיפוש תנך\\TanachProject\\Da_Repository\\bin\\Debug\\net7.0\\Letters.json");

            Dictionary<Char, int> d = new Dictionary<Char, int>();
            d = JsonConvert.DeserializeObject<Dictionary<Char, int>>(existingJson);
            return d;
        }
    }
}
