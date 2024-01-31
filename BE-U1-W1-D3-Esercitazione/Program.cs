using System;

namespace BE_U1_W1_D3_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un oggetto ContoCorrente
            ContoCorrente contoUtente1 = new ContoCorrente();

            // Apertura del conto per l'utente con numero conto 123456789
            contoUtente1.AperturaConto( 123456789);

            // Visualizzazione del saldo iniziale del conto
            contoUtente1.VisualizzaSaldo();

            // Versamento di 1500 euro nel conto
            contoUtente1.Versamento(1500);

            // Visualizzazione del saldo dopo il versamento
            contoUtente1.VisualizzaSaldo();

            // Prelievo di 500 euro dal conto
            contoUtente1.Prelievo(500);

            // Visualizzazione del saldo dopo il prelievo
            contoUtente1.VisualizzaSaldo();


            //----------------------------------------------------//


            // Array di stringhe
            string[] vettore = { "Mario", "Luca", "Attila", "Beppe", "Giuda" };

            // Richiesta all'utente di inserire un nome da cercare
            Console.WriteLine("Inserisci il nome da cercare:");
            string nome = Console.ReadLine();
            bool nomePresente = false;

            // Ciclo per cercare il nome nell'array
            for (int i = 0; i < vettore.Length; i++)
            {
                if (nome == vettore[i])
                {
                    nomePresente = true;
                    break;
                }
            }

            // Stampa se il nome è presente o meno nell'array
            if (nomePresente)
            {
                Console.WriteLine("Il nome è presente nella lista.");
            }
            else
            {
                Console.WriteLine("Il nome non è presente nella lista.");
            }


            //----------------------------------------------------//


            // Array di interi
            int[] vettore2 = new int[3];

            // Assegnazione di valori agli elementi dell'array
            int x = vettore2[0];
            int y = vettore2[1];
            int z = vettore2[2];

            x = 3; y = 5; z = 7;

            // Calcolo della somma e della media degli elementi dell'array di interi
            int somma = x + y + z;
            int media = somma / vettore2.Length;

            // Stampa della somma e della media
            Console.WriteLine("La somma dei numeri è: " + somma);
            Console.WriteLine("La media dei numeri è: " + media);

            // Attesa dell'input dell'utente prima di chiudere l'applicazione
            Console.ReadLine();
        }
    }
}
