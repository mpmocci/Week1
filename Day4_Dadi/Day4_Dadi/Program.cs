using System;

namespace week1_day4_dadi
{
    class Program
    {
        static void Main(string[] args)
        {
            /********Lancio dei dati. Scrivere un programma completo. L'utente inserisce un numero tra 2 e 12
   Il computer lancia 2 dadi, cioè sorteggia 2 numeri random tra 1 e 6.
   Se la somma dei due numeri random è pari al numero scelto dall'utente, l'utente vince
   Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
   Finita la partita l'utente deve poter rigiocare
   Requisiti:
   *verificare che l'utente inserisca un intero e che sia compreso tra 2 e 12.
   Se la verifica non va a buon fine, l'utente deve potere inserire nuovamente il numero.
   Suggerimento:
   *Creare un metodo per l'inserimento dei numeri e la verifica, uno per il controllo
   della vittoria(da chiamare nel main)*********************************/


            bool replay = false;

            do
            {
                Random rnd = new Random();

                int rnd1 = rnd.Next(2, 13);
                int rnd2 = rnd.Next(2, 13);

                Console.WriteLine($" {rnd1} e {rnd2}");


                Console.WriteLine("Inserisci un numero compreso tra 2 e 12.");
                int num = Convert.ToInt32(Console.ReadLine());

                VerificaNumero(num);
                ControlloVittoria(num, rnd1, rnd2);

                Console.WriteLine("Vuoi rigiocare? Premi \n" +
                    "[1] per rigiocare \n" +
                    "[2] per uscire ");


                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        replay = true;
                        break;

                    case '2':

                        return;

                }

            }

            while (replay == true);




        }


        private static void VerificaNumero(int a)
        {
            int num;

            if (a > 1 && a < 13)
            {

            }

            else
            {
                do
                {
                    Console.WriteLine("Numero inserito non corretto. Inserisci un numero compreso tra 2 e 12.");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                while (num < 2 || num > 12);

            }

        }

        private static void ControlloVittoria(int x, int random1, int random2)

        {
            if (random1 + random2 == x)
            {
                Console.WriteLine("Hi vinto!");
            }

            else

            {
                Console.WriteLine("Hai perso.");
            }

        }



    }
}
