using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscrizioneEsami
{
   public class Corso
    {
        //Un Corso ha un Nome e dei CFU.
        public string NomeCorso { get; set; }
        public int Cfu { get; set; }
        public Esame Esame { get; set; }

        public Corso()
        {

        }
        public Corso(string nomeCorso, int cfu, Esame esame )
        {
            NomeCorso = nomeCorso;
            Cfu = cfu;
            Esame = esame;
        }

        public string GetInfo()
        {
            return $" Nome corso: {NomeCorso}, Cfu: {Cfu}, Stato esame: {Esame}";
        }


    }


}
public enum Esame
{
    Promosso,
    Bocciato


}
