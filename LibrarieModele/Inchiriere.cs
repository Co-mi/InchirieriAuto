

namespace LibrarieModele
{
    public class Inchiriere
    {
        //Constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int CNP = 1;
        private const int ID = 0;
        private const int DATA_INC = 2;
        private const int DATA_TER = 3;

        public int ID_inchiriere { get; set; }
        public string CNP_client { get; set; }
        public string dataIncepere { get; set; }
        public string dataTerminare { get; set; }

        public Inchiriere(string _date)
        {
            string[] date = _date.Split(',');
            CNP_client = date[CNP];
            int.TryParse(date[ID], out int id);
            ID_inchiriere = id;
            dataIncepere = date[DATA_INC];
            dataTerminare = date[DATA_TER];
        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"ID inchiriere: {ID_inchiriere}\nCNP client: {CNP_client}\nInterval inchiriere: {dataIncepere} - {dataTerminare}";
            return dateForDisplay;
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, ID_inchiriere,(CNP_client ?? " NECUNOSCUT "), ID_inchiriere , (dataIncepere ?? " NECUNOSCUT "), (dataTerminare ?? " NECUNOSCUT "));
            return s;
        }
    }
}
