using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public class Perek
    {
        public string Text { get; set; }
        public string NamePerek { get; set; }
        public List<Pasuk> Psukim { get; set; }

        public Perek()
        {
            Psukim = new List<Pasuk>();
        }
    }
}
