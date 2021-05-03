

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
        public string Model { get; set; }
        public string Serie { get; set; }
        public int Pret { get; set; }

        public Masina(string data)
        {
            string[] _date = data.Split(',');
            Model = _date[MODEL];
            Serie = _date[SERIE];
            Pret = int.Parse(_date[PRET]);

        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"Model: {Model}\nSerie: {Serie}\nPret inchiriere: {Pret}";
            return dateForDisplay;
        }
        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER, (Model ?? " NECUNOSCUT "), (Serie ?? " NECUNOSCUT "), (Pret.ToString() ?? " NECUNOSCUT "));
           
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
