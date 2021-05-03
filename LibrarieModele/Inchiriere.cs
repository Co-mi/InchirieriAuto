

namespace LibrarieModele
{
    public class Inchiriere
    {
        int ID_inchiriere { get; set; }
        string CNP_client { get; set; }
        public string dataIncepere { get; set; }
        public string dataTerminare { get; set; }

        public Inchiriere(string _date)
        {
            string[] date = _date.Split(',');
            CNP_client = date[0];
            int ID = ID_inchiriere;
            int.TryParse(date[1], out ID);
            dataIncepere = date[2];
            dataTerminare = date[3];
        }

        public string ConversieLasir()
        {
            string dateForDisplay = $"ID inchiriere: {ID_inchiriere}\nCNP client: {CNP_client}\nInterval inchiriere: {dataIncepere} - {dataTerminare}";
            return dateForDisplay;
        }
    }
}
