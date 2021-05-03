using System;

namespace LibrarieModele
{
    public class Angajat : Persoana
    {
        //Constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

  
        private const int FUNCTIE = 3;

        string Functie { get; set; }

        public Angajat(string _date):base(_date)
        {
            string[] Date = _date.Split(',');
            Functie = Date[FUNCTIE];
        }

        public override string ConversieLaSir()
        {
            string dateForDiplay = $"Nume: {Nume} {Prenume}\nCNP: {CNP}\nFunctie: {Functie}";

            return dateForDiplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (CNP ?? " NECUNOSCUT "),(Functie ?? " NECUNOSCUT "));
            return s;
        }
    }
}
