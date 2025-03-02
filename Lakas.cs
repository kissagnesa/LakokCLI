using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakokCLI
{
    public class Lakas
    {
        public string Cim { get; private set; }
        public int LakokSzama { get; private set; }
        public string LakokNeve { get; private set; }
        public int Terulet { get; private set; }
        public int Tartozas { get; private set; }

        public Lakas(string sor)
        {
            string[] adatok = sor.Split(',');
            Cim = adatok[0];
            LakokSzama = int.Parse(adatok[1]);
            LakokNeve = adatok[2];
            Terulet = int.Parse(adatok[3]);
            Tartozas = int.Parse(adatok[4]);
        }

        public bool Tartozik()
        {
            return Tartozas > 0;
        }

        public bool Tulzsufolt()
        {
            int maxLakokSzama = (Terulet - 40) / 4;
            return LakokSzama > maxLakokSzama;
        }

        public override string ToString()
        {
            return $"{Cim}, {LakokSzama} fő, {Terulet} m², {Tartozas} Ft, {LakokNeve}";
        }
    }
}
