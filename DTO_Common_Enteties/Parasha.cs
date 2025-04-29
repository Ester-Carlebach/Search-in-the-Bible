using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public class Parasha
    {
        public string NameParasha { get; set; }
        public List<Perek> Prakim { get;}
        public Parasha(string name,List<Perek> l)
        {
            NameParasha = name;
            Prakim = l;
        }

    }
}
