using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscrizioneEsami
{
    public class Immatricolazione
//Matricola(La matricola dello studente deve essere univoca, autogenerata e read-only)
//DataInizio CorsoDiLaurea
//FuoriCorso
//CFUAccumulati

    {
        public static int inizioMatricola = 100;
        public int Matricola { get; }
        public DateTime DataInizio { get; set; } = new DateTime();
        public bool FuoriCorso { get; set; }
        public int CfuAccumulati { get {return CalcolaCfuAccumulati(); } }
        public List<CorsoDiLaurea> CorsiDiLaurea = new List<CorsoDiLaurea>();

        private int CalcolaCfuAccumulati()
        {
            int tot = 0;
            foreach (var item in CorsiDiLaurea)
            {
                tot = tot + item.CreditiLaurea;
            }
            return tot;
        }

        public Immatricolazione()
        {

        }
        public Immatricolazione(DateTime dataInizio, bool fuoriCorso, int cfuAccumulati)
        {
            DataInizio = dataInizio;
            FuoriCorso = fuoriCorso;
            Matricola = inizioMatricola++;
        }

        public void StampaImmatricolazione() //Stampa Corso Di Laurea
        {
            Console.WriteLine($"Riepilogo corsi:  ");
            foreach (var item in CorsiDiLaurea)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine($"\n Totale Crediti: {CalcolaCfuAccumulati()}");
        }
    }
}
