using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDeseni2
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.Siparis();

            Adapter adapter = new Adapter();
            adapter.Siparis();

            Console.ReadKey();
        }
    }
}
