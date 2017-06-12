using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni2
{
    class Target
    {
        public virtual void Siparis() {
            Console.WriteLine("Gitar siparişi verilmiştir");
        }
    }
}
