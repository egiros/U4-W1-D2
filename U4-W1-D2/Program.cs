using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Persona persona1 = new Persona("Mario", "Rossi", 35);
            persona1.GetNome();
            persona1.GetCognome();
            persona1.GetEta();
            Console.WriteLine("Risultato:\n" + persona1.GetDettagli());


            Console.WriteLine("\n\n\nInserire Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserire Cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserire Età: ");
            string eta = Console.ReadLine();

            Console.WriteLine("\n\nHai inserito: \nNome: " + nome + "\nCognome: " + cognome + "\nAnni: " + eta);

            Console.ReadLine();

        }
    }
}
