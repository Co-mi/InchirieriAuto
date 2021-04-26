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
            Persoana p = new Persoana("Andrei,Orodici,555016270888"); //constructor Persoana
            Console.WriteLine("Afisare informatii persoana:\n"+p.ConversieLaSir());

            Masina m = new Masina("BMW,ACFDFDSADSFSAF8558,200"); //constructor Masina
            Masina m1 = new Masina("Audi,HHGGJHGHHHjh2555X,150"); //constructor Masina
            Console.WriteLine("\nAfisare informatii masina 1:"+m.ConversieLaSir());
            Console.WriteLine("\nAfisare informatii masina 2:"+m1.ConversieLaSir());
            Console.WriteLine("\nPretul masinii 1 este mai mare decat pretul masinii 2? Answer: {0}", m > m1);

            Client c = new Client("George,Toader,1547698200457,12-89-56-88"); //constructor Client 
            Console.WriteLine("\nAfisare informatii client:\n"+c.ConversieLaSir());

            Angajat a = new Angajat("Croitoru,Adriana,1058645289958,Receptioner");//constructor Angajat
            Console.WriteLine("\nAfisare informatii angajat:\n"+a.ConversieLaSir());

            Inchiriere inc = new Inchiriere("5551466845568,000120,20/04/2021,30/04-2021");//constructor Inchiriere
            Console.WriteLine("\nAfisare informatii inchiriere:\n"+inc.ConversieLasir());

            Console.ReadKey();
        }
    }
}

