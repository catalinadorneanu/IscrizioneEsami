using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscrizioneEsami
{
    public class Studente
    // Lo studente è definito con:
    //Nome
    //Cognome
    //AnnoDiNascita
    //Immatricolazione esame
    //RichiestaLaurea
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; } = new DateTime();
        public Immatricolazione Immatricolazione { get; set; }
        public bool RichiestaLaurea { get; set; }
      

        public Studente()
        {

        }
        public Studente(string nome, string cognome, DateTime dataDiNascita, bool richiestaLaurea)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            RichiestaLaurea = richiestaLaurea;
            
        }
        public string StampaStudente()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Matricola:{Immatricolazione.Matricola}";
        }
    }
}
