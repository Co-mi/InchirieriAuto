using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Masina
    {
        string model;
        string serie;
        int pret;

        public Masina(string data)
        {
            string[] _date = data.Split(',');
            model = _date[0];
            serie = _date[1];
            pret = Int32.Parse(_date[2]);

        }

        public string ConversieLaSir()
        {
            string dateForDisplay = $"Model: {model}\nSerie: {serie}\nPret inchiriere: {pret}";
            return dateForDisplay;
        }

        public static bool operator <(Masina m1, Masina m2)
        {

            if (m1.pret < m2.pret)
                return true;
            else
                return false;
        }

        public static bool operator >(Masina m1, Masina m2)
        {

            if (m1.pret > m2.pret)
                return true;
            else
                return false;
        }
    }
}
