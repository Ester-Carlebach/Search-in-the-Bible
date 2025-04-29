using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public class LocationPasuk: Location
    {
        public string Perek { get; set; }
        public string Pasuk { get; set; }
        public string Text { get; set; }
        public string Sefer { get; set; }

        public LocationPasuk(string sefer,string perek, string pasuk,string text)
        {
            Perek=perek;
            Pasuk=pasuk;
            Text=text;  
            Sefer = sefer;
        }
        public override string ToString()
       {
           return "( Sefer:  " + Sefer + "   Perek:  " + Perek + "   Pasuk:   " + Pasuk + "' " + " )";
       }
       // public override string ToString()
      //  {
        //    return Text;
       // }


    }
}
