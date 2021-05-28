using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscrizioneEsami
{
    class GestioneCorsiDiLaurea
    {
        public static List<Corso> corsi = new List<Corso>();

        public static List<Corso> InserisciCorsi()
        {
            Corso c1 = new Corso("Algebra I", 12, (Esame)1) ;
            Corso c2 = new Corso("Logica Matematica", 8, (Esame)0);
            Corso c3 = new Corso("Statistica", 20, (Esame)1);

            corsi.Add(c1);
            corsi.Add(c2);
            corsi.Add(c3);
            return corsi;
        }

        public static List<CorsoDiLaurea> corsiDiLaurea = new List<CorsoDiLaurea>();

        public static List<CorsoDiLaurea> InserisciCDL()
        {
            CorsoDiLaurea cdl1 = new CorsoDiLaurea("Matematica", 3,30);
            CorsoDiLaurea cdl2 = new CorsoDiLaurea("Informatica", 3,30);
            CorsoDiLaurea cdl3 = new CorsoDiLaurea("Fisica", 2,20);
            CorsoDiLaurea cdl4 = new CorsoDiLaurea("Ingegneria", 5,50);

            corsiDiLaurea.Add(cdl1);
            corsiDiLaurea.Add(cdl2);
            corsiDiLaurea.Add(cdl3);
            corsiDiLaurea.Add(cdl4);
            return corsiDiLaurea;
        }

        //public static List<Studente> studenti = new List<Studente>();

        //public static List<Studente> InserisciStudenti()
        //{
        //   Studente s1 = new Studente("Catalina", "Dorneanu", new DateTime (1993,04,29), true);
        //   Studente s2 = new Studente("Bianca", "Rossi", new DateTime (1988,09,17), false);


        //    studenti.Add(s1);
        //    studenti.Add(s2);
        //    return studenti;
        //}

        public static List<Studente> studenti = new List<Studente>() {

            new Studente() { Nome = "Catalina", Cognome = "Dorneanu" , DataDiNascita= new DateTime (1993,04,29) , RichiestaLaurea = true }

        };
        public static Studente IsImmatricolato(string nome, string cognome)
        {
            foreach (var item in studenti)
            {
                if (item.Nome == nome && item.Cognome == cognome)
                {
                    item.StampaStudente();
                    return item;
                }

            }
            return null;
        }
        public static CorsoDiLaurea CercaCDLperNome(string nome)
        {
            nome = "matematica";
            foreach (var item in corsiDiLaurea)
            {
                if (item.NomeCorsoDiLaurea == "Matematica")
                {
                    Console.WriteLine(item.GetInfo());
                    return item;
                }
            }
            return null;
        }



    }
}
