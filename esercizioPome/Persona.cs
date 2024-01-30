using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace esercizioPome
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        // Costruttore Persona:
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
        // Metodi:
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

        public string GetDettagli() { return "Nome: " + Nome + "\t" + "Cognome: " + Cognome + "\t" + "Età: " + Eta; }
    }
}
