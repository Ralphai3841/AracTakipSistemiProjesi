using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakipSistemiProjesi
{
    internal class Arac
    {
        private string plaka;
        private string tipi;
        private string from;
        private string to;
        private PointLatLng konum;

        public Arac(string plaka, string tipi, string from, string to, PointLatLng konum)
        {
            this.Plaka = plaka;
            this.Tipi = tipi;
            this.From = from;
            this.To = to;
            this.Konum = konum;
        }

        public string Plaka { get => plaka; set => plaka = value; }
        public string Tipi { get => tipi; set => tipi = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public PointLatLng Konum { get => konum; set => konum = value; }

        public override string ToString()
        {
            string str = "\n" + Plaka + "\n"  + Tipi + "\n" + From + "\n" + To;
            return str;
        }
    }
}
