using DTO_Common_Enteties;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

//System.IO.StreamReader objReader;


namespace Da_Repository
{

    public class Class1
    {
        //פןנקציה המחזירה את כל התנך
        public static string AllTanach()
        {
            string s = File.ReadAllText("C:\\Users\\This User\\Documents\\מסלול\\שנה ב\\פרויקטים\\C#\\AllTora.txt");

            return s;

        }
    }
}