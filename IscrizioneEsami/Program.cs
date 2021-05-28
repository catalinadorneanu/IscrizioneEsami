using System;

namespace IscrizioneEsami
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome: ");
            string cognome = Console.ReadLine();
            Studente stud = GestioneCorsiDiLaurea.IsImmatricolato(nome, cognome);
            if (stud == null)
            {
                Console.WriteLine("\nNon sei uno studente");

            }
            else
            {
                Console.WriteLine("Accesso effettuato");
            }

            //visualizza corsi di laurea disponibili
            var listaCDL = GestioneCorsiDiLaurea.InserisciCDL();
            if (listaCDL.Count > 0)
            {
                Console.WriteLine("\n----------Corsi di laurea disponibili----------");
                foreach (var item in listaCDL)
                {
                    Console.WriteLine($"{item.GetInfo()}");
                }

                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Inserisci il nome del Corso di Laurea che vuoi scegliere (Matematica):");
                string nomeCDL = Console.ReadLine();
                //verifichiamo se esite il COrso di laurea scelto
                CorsoDiLaurea cdl = GestioneCorsiDiLaurea.CercaCDLperNome(nomeCDL);
                if (cdl == null)
                {
                    Console.WriteLine("Corso non identificato");
                }
                else
                {
                    var listaCorsi = GestioneCorsiDiLaurea.InserisciCorsi();
                    if (listaCorsi.Count > 0)
                    {
                        Console.WriteLine("\n----------Esami del Corso di Laurea in Matematica----------");
                        foreach (var item in listaCorsi)
                        {
                            Console.WriteLine($"{item.GetInfo()}");
                        }

                        Console.WriteLine("------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Nessun esame disponibile");
                    }


                    ////qui avrei voluto far scegliere l'esame da sostenere, ed aggiungere esami finché non raggiunge il massimo di crediti del corso di laurea
                    ///
                    //    Console.WriteLine("\n----------Inserisci il nome dell'esame che vuoi sostenere----------");



                    //    int creditiEsame = 0;    //crediti singolo esame
                    //    int creditiCDL = 0; //totale crediti corso di laurea
                    //    int creditiMancanti = 0; //quanti crediti mancano per potersi laureare
                    //    do
                    //    {
                    //        creditiEsame = int.Parse(Console.ReadLine());
                    //        creditiCDL += creditiEsame;
                    //        creditiMancanti = creditiCDL - creditiEsame;

                    //        if (creditiEsame < creditiCDL)
                    //        {
                    //            Console.WriteLine($"Aggiungi un altro esame {creditiMancanti}");
                    //        }

                    //    }
                    //    while (creditiCDL > creditiEsame);
                    //    Console.WriteLine($"Aggiungi un altro esame {creditiMancanti}");






                }
            }
            }
        }
    }


