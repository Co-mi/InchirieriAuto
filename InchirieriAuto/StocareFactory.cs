using NivelAccesDate;
using System.Configuration;

namespace InchirieriAuto
{
    class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_CLIENTI = "NumeFisierClienti";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";
        private const string NUME_FISIER_MASINI = "NumeFisierMasini";
        private const string NUME_FISIER_INCHIRIERI = "NumeFisierInchirieri";

        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierClienti = ConfigurationManager.AppSettings[NUME_FISIER_CLIENTI];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];
            var numeFisierMasini = ConfigurationManager.AppSettings[NUME_FISIER_MASINI];
            var numeFisierInchirieri = ConfigurationManager.AppSettings[NUME_FISIER_INCHIRIERI];
            if(formatSalvare != null)
            {
                return new AdministrareFirma_FisiereText(numeFisierClienti + "." + formatSalvare, numeFisierAngajati + "." + formatSalvare,
                    numeFisierMasini + "." + formatSalvare, numeFisierInchirieri + "." + formatSalvare);
            }
            return null;
        }
    }
}
