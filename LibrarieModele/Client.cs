using System;

namespace LibrarieModele
{
    public class Client: Persoana
    {
        //Constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
       
        public int[] ID_Inchirieri { get; set; }


        public Client(string data) : base(data)
        {
            string[] _date = data.Split(',');
            string[] _Date = _date[3].Split('-');

            ID_Inchirieri = new int[_Date.Length];
            for (int i = 0; i < ID_Inchirieri.Length; i++)
            {
                ID_Inchirieri[i] = int.Parse(_Date[i]);
            }
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"Nume: {Nume} {Prenume}\nCNP: {CNP}\nID inchiriere:  ";
            foreach (int inchiriere in ID_Inchirieri)
            {

                dateForDisplay += $"{inchiriere}-";
            }

            dateForDisplay = dateForDisplay.TrimEnd('-');
           

            return dateForDisplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,(Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "),(CNP ?? " NECUNOSCUT "));
            foreach (int inchiriere in ID_Inchirieri)
            {

                s += $"{inchiriere}-";
            }
            s = s.TrimEnd('-');
            return s;
        }
    } 
}
