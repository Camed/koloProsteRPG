using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Wojownik();
            var m = new Mag();
            m.Stan();
            w.MakeAttack(m);
            m.Stan();
            Console.ReadKey();
        }
    }
}
