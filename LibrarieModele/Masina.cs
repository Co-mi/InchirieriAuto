using System;

namespace LibrarieModele
{
    public class Masina
    {
        //Constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int MODEL = 0;
        private const int SERIE = 1;
        private const int PRET = 2;
        private const int OPTIUNI = 3;
        public ModelMasina Model { get; set; }

        public OptiuniMasina Optiuni { get; set; } 
        public string Serie { get; set; }
        public int Pret { get; set; }

        public Masina(string data)
        {
            string[] _date = data.Split(',');
            Model = (ModelMasina)Convert.ToInt32(_date[MODEL]);
            Serie = _date[SERIE];
            Pret = int.Parse(_date[PRET]);

            Optiuni = (OptiuniMasina)0;
            string[] optiuni = _date[OPTIUNI].Split('-');

            foreach (string optiune in optiuni)
            {
                Optiuni |= (OptiuniMasina)int.Parse(optiune);
            }
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"Model: {Model}\nSerie: {Serie}\nPret inchiriere: {Pret}\nOptiuni: {Optiuni}";
            return dateForDisplay;
        }
        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, (int)Model, (Serie ?? " NECUNOSCUT "), (Pret.ToString() ?? " NECUNOSCUT "),(int)Optiuni);
           
            return s;
        }
        public static bool operator <(Masina m1, Masina m2)
        {

            if (m1.Pret < m2.Pret)
                return true;
            else
                return false;
        }

        public static bool operator >(Masina m1, Masina m2)
        {

            if (m1.Pret > m2.Pret)
                return true;
            else
                return false;
        }
    }
}
