using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni2
{
    class Adapter:Target
    {
        Adaptee adapter = new Adaptee();
        public override void Siparis()
        {
            adapter.KemenceSiparisi();
        }
    }
}
