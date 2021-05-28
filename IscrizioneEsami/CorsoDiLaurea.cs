using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscrizioneEsami
{
    public class CorsoDiLaurea
//Un Corso di laurea è dato da:
//Nome,
//AnniDiCorso,
//Cfu per ottenere la laurea
//lista di corsi associati.
//I possibili nomi dei Corsi di Laurea possono essere solo i seguenti: Matematica, Fisica, Informatica, Ingegneria, Lettere.

    {
     
        public string NomeCorsoDiLaurea { get; set; }
        public int AnniDiCorso { get; set; }
        public List<Corso> Corsi { get; set; } = new List<Corso>();
        public int CreditiLaurea { get; set; }

       
        public CorsoDiLaurea()
        {

        }
        public CorsoDiLaurea(string nomeCorsoDiLaurea, int anniDiCorso, int creditiLaurea)
        {
            NomeCorsoDiLaurea = nomeCorsoDiLaurea;
            AnniDiCorso = anniDiCorso;
            CreditiLaurea = creditiLaurea;
        }

        public string GetInfo()
        {
            return $"Nome Corso di laurea: {NomeCorsoDiLaurea}, Durata Corso: {AnniDiCorso},  Crediti per laurearsi: {CreditiLaurea}";
        }
    }
    
}
