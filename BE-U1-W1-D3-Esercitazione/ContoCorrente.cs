using System;

namespace BE_U1_W1_D3_Esercitazione
{
    internal class ContoCorrente
    {
        // Proprietà del conto corrente
        public string Titolare { get; set; }
        public int NumeroConto { get; set; }
        public double Saldo { get; set; }

        public bool contoAperto = false;

        // Metodo per l'apertura del conto
        public void AperturaConto( int numeroConto, double saldo = 1000.0)
        {
            if (!contoAperto)
            {
                Console.Write("Inserisci il nome del titolare del conto: ");
                Titolare = Console.ReadLine();
                NumeroConto = numeroConto;
                Saldo = saldo;
                contoAperto = true;

                // Messaggio di conferma dell'apertura del conto
                Console.WriteLine("Il conto di " + Titolare + ", numero: " + NumeroConto + " con un versamento iniziale di " + Saldo + " è stato aperto con successo!");
            }
            else
            {
                // Messaggio in caso il conto sia già aperto
                Console.WriteLine("Il conto è già stato aperto.");
            }
        }

        // Metodo per effettuare un versamento
        public void Versamento(double importo)
        {
            if (contoAperto)
            {
                Saldo += importo;

                // Messaggio di conferma del versamento
                Console.WriteLine("Versamento di " + importo + " effettuato con successo!");
            }
            else
            {
                // Messaggio se il conto non è aperto
                Console.WriteLine("Il conto non è aperto.");
            }
        }

        // Metodo per effettuare un prelievo
        public void Prelievo(double importo)
        {
            if (contoAperto && importo <= Saldo)
            {
                Saldo -= importo;

                // Messaggio di conferma del prelievo
                Console.WriteLine("Prelievo di " + importo + " effettuato con successo!");
            }
            else
            {
                // Messaggio se il conto non è aperto o ci sono fondi insufficienti
                Console.WriteLine("Il conto non è aperto o fondi insufficienti");
            }
        }

        // Metodo per visualizzare il saldo
        public void VisualizzaSaldo()
        {
            // Messaggio che mostra il saldo disponibile
            Console.WriteLine("Il saldo disponibile è: " + Saldo);
        }
    }
}
