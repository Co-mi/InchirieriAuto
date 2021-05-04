using LibrarieModele;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        #region Clienti
        void AddClient(Client client);
        void UpdateFisierClienti(List<Client> clienti);
        Client GetClient(string nume, string prenume);//aici trb schimbat cu string data
        List<Client> GetClienti();
        #endregion

        #region Angajati
        void AddAngajat(Angajat angajat);

        void UpdateFisierAngajati(List<Angajat> angajati);

        Angajat GetAngajat(string nume, string prenume);

        List<Angajat> GetAngajati();
        #endregion
        
        #region Masini
        void AddMasina(Masina masina);
        void UpdateFisierMasini(List<Masina> masini);
        Masina GetMasina(string serie);

        List<Masina> GetMasini();
        #endregion
        
        #region Inchirieri
        void AddInchiriere(Inchiriere inchiriere);
        void UpdateFisierInchirieri(List<Inchiriere> inchirieri);
        Inchiriere GetInchiriere(int ID_inchiriere);
        List<Inchiriere> GetInchirieri();
        #endregion
        
    }
}
