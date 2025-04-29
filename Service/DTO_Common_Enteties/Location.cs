using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public  class Location 
    {
        public string Perek { get; set; }
        public string Pasuk { get; set; }
        public string Text { get; set; }
        public string Sefer { get; set; }
        public int Gimatria { get; set; }
        public Location()
        {
            
        }
        public Location(int gimatria,string sefer, string perek, string pasuk, string text)
        {
            Perek = perek;
            Pasuk = pasuk;
            Text = text;
            Sefer = sefer;
            Gimatria = gimatria;
        }
        public override string ToString()
        {
            return "  פסוק: " + Pasuk + "  פרק:  " + Perek + "  ספר: " + Sefer;
        }
    }

}
