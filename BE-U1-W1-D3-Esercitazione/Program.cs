using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D3_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente contoUtente1 = new ContoCorrente();
            contoUtente1.AperturaConto("Luca Rossi", 123456789);

            contoUtente1.VisualizzaSaldo();
            contoUtente1.Versamento(1500);
            contoUtente1.VisualizzaSaldo();
            contoUtente1.Prelievo(500);
            contoUtente1.VisualizzaSaldo();


            //----------------------------------------------------//


            string[] vettore = { "Mario", "Luca", "Attila", "Beppe", "Giuda" };

            Console.WriteLine("Inserisci il nome da cercare:");
           
            string nome = Console.ReadLine();
            bool nomePresente = false;

            for (int i = 0; i < vettore.Length; i++)
            {
                if (nome == vettore[i])
                {
                    nomePresente = true;
                    break; 
                }
            }

            if (nomePresente)
            {
                Console.WriteLine("Il nome è presente nella lista.");
            }
            else
            {
                Console.WriteLine("Il nome non è presente nella lista.");
            }



            //----------------------------------------------------//


            int[] vettore2 = new int[3];

            int x = vettore2[0];
            int y = vettore2[1];
            int z = vettore2[2];

            x = 3; y= 5; z = 7;   

            int somma = x + y + z;
            int media = somma/vettore2.Length;

            Console.WriteLine("La somma dei numeri è: " + somma);
            Console.WriteLine("La media dei numeri è: " + media);

            Console.ReadLine() ;
        }
    }
}
