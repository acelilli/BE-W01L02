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
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
        // metodo
        public string getDettagli() { return "Nome: " + Nome + "\t" + "Cognome: " + Cognome + "\t" + "Età: " + Eta; }
    }
}
