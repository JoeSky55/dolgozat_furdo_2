using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furdo_fealdat_gal_jozsef
{
    internal class Adatsor
    {
        public int azonosito { get; set; }
        public int reszlegazonosito { get; set; }
        public bool bekilepes { get; set; }
        public DateTime ido { get; set; }
        /*public int ora { get; set; }
        public int perc { get; set; }
        public int masodperc { get; set; }
        */
        
        
        public Adatsor(string sor)
        {
            string[] s = sor.Split(' ');
            azonosito = int.Parse(s[0]);
            reszlegazonosito = int.Parse(s[1]);
            if (int.Parse(s[2]) == 0 )
            {
                bekilepes = true;
            }
            DateTime.Parse(s[3]);


            /*ora = int.Parse(s[3]);
            perc = int.Parse(s[4]);
            masodperc = int.Parse(s[5]);
            */
        }
            
   
    }
}
