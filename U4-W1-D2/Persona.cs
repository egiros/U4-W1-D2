using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }



        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;

        }


        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }


        public int GetEta()
        {
            return Eta;
        }


        public string GetDettagli()
        {
            string messaggio = Nome + "\t" + Cognome + "\t" + "Anni: " + Eta;
            return messaggio;
        }

    }

  
}

