using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D3_Esercitazione
{
    internal class ContoCorrente
    {
        public string Titolare { get; set; }
        public int NumeroConto { get; set; }
        public double Saldo { get; set; }

        public bool contoAperto = false;


        public void AperturaConto(string titolare, int numeroConto, double saldo=1000.0)
        {
            if(!contoAperto)
            {
                Titolare = titolare;
                NumeroConto = numeroConto;
                Saldo = saldo;
                contoAperto = true;

                Console.WriteLine("Il conto di " + Titolare + ", numero: " + NumeroConto + " con un versamento iniziale di " + Saldo + " è stato aperto con successo!");
            }
            else
            {
                Console.WriteLine("Il conto è gia stato aperto.");
            }

            
            /*Console.WriteLine("Vuoi aprire un nuovo conto? Scrivi si o no");
           string risposta = Console.ReadLine();
            if(risposta == "si") 
            {
                Console.WriteLine("Inserisci il numero del conto: ");
             int numeroDelConto = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Inserisci il tuo nome e cognome: ");
                string titolareDelConto = Console.ReadLine();

                int saldoIniziale = 
                    }*/

        }

        public void Versamento (double importo) 
        { 
            if(contoAperto)
            {
                Saldo += importo;
                Console.WriteLine("Versamento di " + importo + " effettuato con successo!");
            }
            else 
            { 
                Console.WriteLine("Il conto non è aperto."); 
            }
        
        }

        public void Prelievo (double importo)
        {
            if (contoAperto && importo <= Saldo )
            { 
                Saldo -= importo;
                Console.WriteLine("Prelievo di " + importo + " effettuato con successo!");
            }
            else 
            { 
                Console.WriteLine("Il conto non è aperto o fondi insufficienti");
            }
        }

        public void VisualizzaSaldo ()
        { 
            Console.WriteLine("Il saldo disponibile è: " + Saldo);
        }

    }
}
