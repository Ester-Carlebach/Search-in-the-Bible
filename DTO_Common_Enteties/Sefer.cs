using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Common_Enteties
{
    public class Sefer
    {
        public string SeferName { get; set; }
        public List<Perek> PerekList { get; set; }
        public string Text { get; set; }

        public Sefer()
        {
            PerekList = new List<Perek>();           
        }
        public override string ToString()
        {
            return SeferName;
        }
    }
}
