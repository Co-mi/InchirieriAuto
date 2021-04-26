using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana();
            Console.WriteLine(p.PreluareDate());
            Console.ReadKey();
        }
    }
}

