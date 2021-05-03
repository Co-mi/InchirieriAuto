using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierText implementeaza interfata IStocareData
    public class AdministrareFirma_FisiereText : IStocareData
    {
        string NumeFisierClienti { get; set; }
        string NumeFisierAngajati { get; set; }
        string NumeFisierMasini { get; set; }
        string NumeFisierInchirieri { get; set; }

        public AdministrareFirma_FisiereText(string numeFisierClienti,string numeFisierAngajati, string numeFisierMasini, string numeFisierInchirieri)
        {
            this.NumeFisierClienti = numeFisierClienti;
            this.NumeFisierAngajati = numeFisierAngajati;
            this.NumeFisierMasini = numeFisierMasini;
            this.NumeFisierInchirieri = numeFisierInchirieri;

            Stream sFisierText = File.Open(numeFisierClienti, FileMode.OpenOrCreate);
            Stream s1FisierText = File.Open(numeFisierAngajati, FileMode.OpenOrCreate);
            Stream s2FisierText = File.Open(numeFisierMasini, FileMode.OpenOrCreate);
            Stream s3FisierText = File.Open(numeFisierInchirieri, FileMode.OpenOrCreate);

            sFisierText.Close();
            s1FisierText.Close();
            s2FisierText.Close();
            s3FisierText.Close();
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

        #region Angajat
        public void AddAngajat(Angajat angajat)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierAngajati, true))
                {
                    swFisierText.WriteLine(angajat.ConversieLaSir_PentruScriereInFisier());
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

        public void UpdateFisierAngajati(List<Angajat> angajati)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierAngajati, false))
                {
                    foreach (Angajat angajat in angajati)
                        swFisierText.WriteLine(angajat.ConversieLaSir_PentruScriereInFisier());
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
        public List<Angajat> GetAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierAngajati))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajat angajatDinFisier = new Angajat(line);
                        angajati.Add(angajatDinFisier);
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

            return angajati;
        }

        public Angajat GetAngajat(string nume, string prenume)
        {
            try
            {
                // instructiunea 'using' va apela sr.close()
                using (StreamReader sr = new StreamReader(NumeFisierAngajati))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Angajat angajatDinFisier = new Angajat(line);
                        if (angajatDinFisier.Nume == nume && angajatDinFisier.Prenume == prenume)
                            return angajatDinFisier;
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

        #region Masina
        public void AddMasina(Masina masina)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierMasini, true))
                {
                    swFisierText.WriteLine(masina.ConversieLaSir_PentruScriereInFisier());
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

        public void UpdateFisierMasini(List<Masina> masini)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisierMasini, false))
                {
                    foreach (Masina masina in masini)
                        swFisierText.WriteLine(masina.ConversieLaSir_PentruScriereInFisier());
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
        public List<Masina> GetMasini()
        {
            List<Masina> masini = new List<Masina>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisierMasini))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina masinaDinFisier = new Masina(line);
                        masini.Add(masinaDinFisier);
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

            return masini;
        }

        public Masina GetMasina(string serie)
        {
            try
            {
                // instructiunea 'using' va apela sr.close()
                using (StreamReader sr = new StreamReader(NumeFisierMasini))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Masina masinaDinFisier = new Masina(line);
                        if (masinaDinFisier.Serie == serie)
                            return masinaDinFisier;
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
