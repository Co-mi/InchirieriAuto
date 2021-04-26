using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Angajat : Persoana
    {
        string functie;

        public Angajat(string _date):base(_date)
        {
            string[] Date = _date.Split(',');
            functie = Date[3];
        }

        public override string ConversieLaSir()
        {
            string dateForDiplay = $"Nume: {nume} {prenume}\nCNP: {CNP}\nFunctie: {functie}";

            return dateForDiplay;
        }
    }
}
