using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    public class AdministrareClienti_FisiereText : IStocareClienti
    {
        string NumeFisierClienti { get; set; }
     

        public AdministrareClienti_FisiereText(string numeFisierClienti)
        {
            this.NumeFisierClienti = numeFisierClienti;
   

            Stream sFisierText = File.Open(numeFisierClienti, FileMode.OpenOrCreate);
           

            sFisierText.Close();

        }
        #region Client
        public void AddClient(Client client)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierClienti, true))
                {
                    swFisierText.WriteLine(client.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
       

        public void UpdateFisierClienti(List<Client> clienti)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierClienti, false))
                {
                    foreach(Client client in clienti)
                        swFisierText.WriteLine(client.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        
        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierClienti))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Client clientDinFisier = new Client(line);
                        clienti.Add(clientDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return clienti;
        }

        public Client GetClient(string nume, string prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.close()
                using (StreamReader sr = new StreamReader(NumeFisierClienti))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Client clientDinFisier = new Client(line);
                        if (clientDinFisier.Nume == nume && clientDinFisier.Prenume == prenume)
                            return clientDinFisier;
                    }
                }
            }
            catch (IOException eio)
            {
                throw new Exception("eroare la deschiderea fisierului. mesaj: " + eio.Message);
            }
            catch (Exception egen)
            {
                throw new Exception("eroare generica. mesaj: " + egen.Message);
            }

            return null;
        }
        #endregion
        
       
    }
}
