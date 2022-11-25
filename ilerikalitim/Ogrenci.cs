using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ilerikalitim
{
    internal class Ogrenci:Temel
    {
        public decimal VizeNotu { get; set; }
        public decimal FinalNotu { get; set; }

        public decimal NotHesapla()
        {
            return (FinalNotu+VizeNotu)/ 2;
        }

    }
}
