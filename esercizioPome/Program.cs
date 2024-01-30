using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioPome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci nome: \t");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome: \t");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci età: \t");
            int eta = int.Parse(Console.ReadLine());
            // Parse = metodo che converte una stringa ad un numero 

            Persona Alice = new Persona(nome, cognome, eta);
            Console.WriteLine(Alice.getDettagli());

            Console.ReadKey();
            // prova per vedere se va git
        }
    }
}
