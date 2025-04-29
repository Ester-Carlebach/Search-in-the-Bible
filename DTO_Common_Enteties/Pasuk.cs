using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public class Pasuk
    {
        public string PasukName { get; set; }
        public string Text { get; set;}

        public override string ToString()
        {
            return Text;
        }
    }
}
