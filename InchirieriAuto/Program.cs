using System;
using System.Collections;
using System.Collections.Generic;
using LibrarieModele;
using NivelAccesDate;

namespace InchirieriAuto
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Client> clienti ;
            List<Angajat> angajati ;
            List<Masina> masini ;

            //variabila de tip interfata 'IStocareData' care este initializata 
            //cu o instanta a clasei 'AdministrareStudenti_FisierText' sau o instanta a clasei 'AdministrareStudenti_FisierBinar' in functie de setarea 'FormatSalvare' din fisierul AppConfig
            IStocareData adminClienti = StocareFactory.GetAdministratorStocare();
            IStocareData adminAngajati = StocareFactory.GetAdministratorStocare();
            IStocareData adminMasini = StocareFactory.GetAdministratorStocare();
           

            clienti = adminClienti.GetClienti();
            angajati = adminClienti.GetAngajati();
            masini = adminClienti.GetMasini();

            while (true)
            {
                Meniu();
                string optiune;
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "AC":
                        AfisareClienti(clienti);
                        break;
                    case "AA":
                        AfisareAngajati(angajati);
                        break;
                    case "AM":
                        AfisareMasini(masini);
                        break;
                    case "CC":
                        Client clientTastatura = CitireClientTastatura();
                        clienti.Add(clientTastatura);
                        //adaugare client in fisier
                        adminClienti.AddClient(clientTastatura);
                        break;
                    case "CA":
                        Angajat angajatTastatura = CitireAngajatTastatura();
                        angajati.Add(angajatTastatura);
                        //adaugare angajat in fisier
                        adminAngajati.AddAngajat(angajatTastatura);
                        break;
                    case "CM":
                        Masina masinaTastatura = CitireMasinaTastatura();
                        masini.Add(masinaTastatura);
                        //adaugare masina in fisier
                        adminMasini.AddMasina(masinaTastatura);
                        break;
                    case "SC":
                        CautareClient(adminClienti);
                        break;
                    case "SA":
                        CautareAngajat(adminAngajati);
                        break;
                    case "SM":
                        CautareMasina(adminMasini);
                        break;
                    case "UC":
                        updateClient(adminClienti,clienti);
                        break;
                    case "UA":
                        updateAngajat(adminAngajati, angajati);
                        break;
                    case "UM":
                        updateMasina(adminMasini, masini);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void Meniu()
        {
            Console.WriteLine("A. Afisare clienti.");
            Console.WriteLine("C. Creare si adaugare client.");
            Console.WriteLine("S. Cauta client in fisier.");
            Console.WriteLine("U. Update client in fisier.");
            Console.WriteLine("X. Inchidere program.");
            Console.WriteLine("Alegeti o optiune.");
        }
        #region Client
        public static void AfisareClienti(List<Client> clienti)
        {
            Console.WriteLine("Clientii sunt:");
            for (int i = 0; i < clienti.Count; i++)
            {
                Console.WriteLine(((Client)clienti[i]).ConversieLaSir());
                Console.WriteLine("\n");
            }

        }
        public static Client CitireClientTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceit cnp-ul:");
            string cnp = Console.ReadLine();

            Console.WriteLine("Introduceti id:");
            string id = Console.ReadLine();

            string numeComplet = nume + "," + prenume + "," + cnp + "," + id;
            Client client = new Client(numeComplet);
            return client;
        }

        public static void CautareClient(IStocareData admminClienti)
        {
            string nume, prenume;
            Console.Write("Introduceti numele clientului cautat: ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele clientului cautat: ");
            prenume = Console.ReadLine();
            Console.WriteLine("Clientul cautat este:");
            Client client_cautat = admminClienti.GetClient(nume, prenume);
            if (client_cautat == null)
                Console.WriteLine("Acest client nu a fost gasit.");
            else
                Console.WriteLine(client_cautat.ConversieLaSir());
        }

        public static void updateClient(IStocareData admminClienti, List<Client> clienti)
        {
            string nume, prenume;
            Console.Write("Introduceti numele clientului ale carui informatii doresti sa le modifici : ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele clientului: ");
            prenume = Console.ReadLine();
            Console.WriteLine("Clientul exista in baza de date...");
            Client client_cautat = admminClienti.GetClient(nume, prenume);
            if (client_cautat == null)
                Console.WriteLine("Acest client nu a fost gasit.");
            else
            {
                Console.WriteLine("Selecteaza ceea ce doresti sa modifici (n-nume, p-prenume, c-CNP, cp = CNP+prenume,etc):");
                string update = Console.ReadLine();
                int i = 0;
                while(clienti[i].CNP!=client_cautat.CNP)
                {
                    i++;
                }
                
           
                if(update.Contains("n"))
                {
                    Console.WriteLine("Introdu noul nume: ");
                    clienti[i].Nume = Console.ReadLine();
                }
                
                if(update.Contains("p"))
                {
                    Console.WriteLine("Introdu noul prenume: ");
                    clienti[i].Prenume = Console.ReadLine();
                }

                if (update.Contains("c"))
                {
                    Console.WriteLine("Introdu noul CNP: ");
                    clienti[i].CNP = Console.ReadLine();
                }
                admminClienti.UpdateFisierClienti(clienti);
                Console.WriteLine("Modificare realizata cu succes!");
            }
        }
        #endregion

        #region Angajat
        public static void AfisareAngajati(List<Angajat> angajati)
        {
            Console.WriteLine("Angajatii sunt:");
            for (int i = 0; i < angajati.Count; i++)
            {
                Console.WriteLine(((Angajat)angajati[i]).ConversieLaSir());
                Console.WriteLine("\n");
            }
        }

        public static Angajat CitireAngajatTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string prenume = Console.ReadLine();

            Console.WriteLine("Introduceit cnp-ul:");
            string cnp = Console.ReadLine();

            Console.WriteLine("Introduceti functia:");
            string functie = Console.ReadLine();

            string numeComplet = nume + "," + prenume + "," + cnp + "," + functie;
            Angajat angajat = new Angajat(numeComplet);
            return angajat;
        }
        public static void CautareAngajat(IStocareData admminAngajati)
        {
            string nume, prenume;
            Console.Write("Introduceti numele angajatului cautat: ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele angajatului cautat: ");
            prenume = Console.ReadLine();
            Console.WriteLine("Angajatul cautat este:");
            Angajat angajat_cautat = admminAngajati.GetAngajat(nume, prenume);
            if (angajat_cautat == null)
                Console.WriteLine("Acest angajat nu a fost gasit.");
            else
                Console.WriteLine(angajat_cautat.ConversieLaSir());
        }
        public static void updateAngajat(IStocareData admminAngajati, List<Angajat> angajati)
        {
            string nume, prenume;
            Console.Write("Introduceti numele angajatului ale carui informatii doresti sa le modifici : ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele angajatului: ");
            prenume = Console.ReadLine();
            Angajat angajat_cautat = admminAngajati.GetAngajat(nume, prenume);
            if (angajat_cautat == null)
                Console.WriteLine("Acest angajat nu a fost gasit.");
            else
            {
                Console.WriteLine("Selecteaza ceea ce doresti sa modifici (n-nume, p-prenume, c-CNP, cp = CNP+prenume,etc):");
                string update = Console.ReadLine();
                int i = 0;
                while (angajati[i].CNP != angajat_cautat.CNP)
                {
                    i++;
                }


                if (update.Contains("n"))
                {
                    Console.WriteLine("Introdu noul nume: ");
                    angajati[i].Nume = Console.ReadLine();
                }

                if (update.Contains("p"))
                {
                    Console.WriteLine("Introdu noul prenume: ");
                    angajati[i].Prenume = Console.ReadLine();
                }

                if (update.Contains("c"))
                {
                    Console.WriteLine("Introdu noul CNP: ");
                    angajati[i].CNP = Console.ReadLine();
                }
                admminAngajati.UpdateFisierAngajati(angajati);
                Console.WriteLine("Modificare realizata cu succes!");
            }
        }
        #endregion

        #region Masina
        public static void AfisareMasini(List<Masina> masini)
        {
            Console.WriteLine("Masinile inscrise sunt:");
            for (int i = 0; i < masini.Count; i++)
            {
                Console.WriteLine(((Masina)masini[i]).ConversieLaSir());
                Console.WriteLine("\n");
            }

        }
        public static Masina CitireMasinaTastatura()
        {
            Console.WriteLine("Introduceti model:");
            string model = Console.ReadLine();

            Console.WriteLine("Introduceti seria:");
            string serie = Console.ReadLine();

            Console.WriteLine("Introduceit pretul:");
            int pret = Convert.ToInt32(Console.ReadLine());

            string numeComplet = model + "," + serie + "," + pret ;
            Masina masina = new Masina(numeComplet);
            return masina;
        }

        public static void CautareMasina(IStocareData admminMasini)
        {
            string serie;
            Console.Write("Introduceti seria masinii pe care o cautati: ");
            serie = Console.ReadLine();
            Console.WriteLine("Masina cautata este:");
            Masina masina_cautata = admminMasini.GetMasina(serie);
            if (masina_cautata == null)
                Console.WriteLine("Acesta masina nu a fost gasita.");
            else
                Console.WriteLine(masina_cautata.ConversieLaSir());
        }

        public static void updateMasina(IStocareData admminMasini, List<Masina> masini)
        {
            string serie;
            Console.Write("Introduceti seria masinii ale carui informatii doresti sa le modifici : ");
            serie = Console.ReadLine();
            Masina masina_cautata = admminMasini.GetMasina(serie);
            if (masina_cautata == null)
                Console.WriteLine("Acesta masina nu a fost gasita.");
            else
            {
                Console.WriteLine("Selecteaza ceea ce doresti sa modifici (m-model, s-serie, p-pret, mp = model+pret,etc):");
                string update = Console.ReadLine();
                int i = 0;
                while (masini[i].Serie != masina_cautata.Serie)
                {
                    i++;
                }


                if (update.Contains("m"))
                {
                    Console.WriteLine("Introdu noul model: ");
                    masini[i].Model = Console.ReadLine();
                }

                if (update.Contains("s"))
                {
                    Console.WriteLine("Introdu noua serie: ");
                    masini[i].Serie = Console.ReadLine();
                }

                if (update.Contains("p"))
                {
                    Console.WriteLine("Introdu noul pret: ");
                    masini[i].Pret = Convert.ToInt32(Console.ReadLine());
                }
                admminMasini.UpdateFisierMasini(masini);
                Console.WriteLine("Modificare realizata cu succes!");
            }
        }
        #endregion

    }
}


////////
//Persoana p = new Persoana("Andrei,Orodici,555016270888"); //constructor Persoana
//Console.WriteLine("Afisare informatii persoana:\n"+p.ConversieLaSir());

//Masina m = new Masina("BMW,ACFDFDSADSFSAF8558,200"); //constructor Masina
//Masina m1 = new Masina("Audi,HHGGJHGHHHjh2555X,150"); //constructor Masina
//Console.WriteLine("\nAfisare informatii masina 1:"+m.ConversieLaSir());
//Console.WriteLine("\nAfisare informatii masina 2:"+m1.ConversieLaSir());
//Console.WriteLine("\nPretul masinii 1 este mai mare decat pretul masinii 2? Answer: {0}", m > m1);

//Client c = new Client("George,Toader,1547698200457,12-89-56-88"); //constructor Client 
//Console.WriteLine("\nAfisare informatii client:\n"+c.ConversieLaSir());

//Angajat a = new Angajat("Croitoru,Adriana,1058645289958,Receptioner");//constructor Angajat
//Console.WriteLine("\nAfisare informatii angajat:\n"+a.ConversieLaSir());

//Inchiriere inc = new Inchiriere("5551466845568,000120,20/04/2021,30/04-2021");//constructor Inchiriere
//Console.WriteLine("\nAfisare informatii inchiriere:\n"+inc.ConversieLasir());