using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriAuto
{
    class Client: Persoana
    {
        int[] id_inchirieri;


        public Client(string data) : base(data)
        {
            string[] _date = data.Split(',');
            string[] _Date = _date[3].Split('-');

            id_inchirieri = new int[_Date.Length];
            for (int i = 0; i < id_inchirieri.Length; i++)
            {
                id_inchirieri[i] = int.Parse(_Date[i]);
            }
        }

        public override string ConversieLaSir()
        {
            string dateForDisplay = $"Nume: {nume} {prenume}\nCNP: {CNP}\nID inchiriere:  ";
            foreach (int inchiriere in id_inchirieri)
            {

                dateForDisplay += $"{inchiriere}-";
            }

            dateForDisplay = dateForDisplay.TrimEnd('-');

            return dateForDisplay;
        }
    } 
}
