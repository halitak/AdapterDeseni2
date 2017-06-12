using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni2
{
    class Adaptee
    {
        public virtual void KemenceSiparisi() {
            Console.WriteLine("Kemençe siparişi verilmiştir");
        }
    }
}
