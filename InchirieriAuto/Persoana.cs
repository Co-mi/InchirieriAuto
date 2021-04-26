using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Persoana
    {
        protected string nume;
        protected string prenume;
        protected string CNP;
        public Persoana()//Constructor implicit
        { 
        }
        public Persoana(string data)
        {
            string[] _date = data.Split(',');
            nume = _date[0];
            prenume = _date[1];
            CNP = _date[2];
            
        }

        virtual public string ConversieLaSir()
        {
            string dateForDisplay = $"Nume: { nume} { prenume}\nCNP: { CNP}";


            return dateForDisplay;
        }
    }
}
