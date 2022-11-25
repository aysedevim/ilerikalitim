using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilerikalitim
{
    internal class Egitmen:Temel
    {
        public string Unvan { get; set; }
        public int BrutMaas { get; set; }

        public int MaasHesapla()
        {
            return Convert.ToInt32(BrutMaas * .70);
        }
    }
}
