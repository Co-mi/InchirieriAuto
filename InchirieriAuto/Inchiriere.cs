using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Inchiriere
    {
        int ID_inchiriere;
        string CNP_client;
        public string dataIncepere;
        public string dataTerminare;

        public Inchiriere(string _date)
        {
            string[] date = _date.Split(',');
            CNP_client = date[0];
            int.TryParse(date[1], out ID_inchiriere);
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
