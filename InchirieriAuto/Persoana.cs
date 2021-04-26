using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Persoana
    {
        public string nume;
        public string prenume;
        public string CNP;
        public Persoana()
        {
            nume = "Neinregistrat";
            prenume = "Neinregistrat";
            CNP = "-------------";
        }

        public string PreluareDate()
        {
            return $"Nume: {nume}\nPrenume: {prenume}\nCNP: {CNP}";    
        }
    }
}
