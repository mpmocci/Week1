using System;

namespace Esercitazione_week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 1: messaggio di benvenuto scritto in rosso

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Benvenuto a Tombola!");
            Console.ForegroundColor = ConsoleColor.White;

            int[] chosenNumbers = new int[5];
            int[] extractedNumbers = new int[20];

            //Variabile per definire la possibilità di rigiocare
            bool replay = false;

            do
            {
                //PUNTO 2: l'utente sceglie inserire 5 o 15 numeri numeri 


                Console.WriteLine("\n *******Digita quanti numeri vuoi scegliere, 5 o 15.******** \n");

                int choiceChosen = Convert.ToInt32(Console.ReadLine());



                //PUNTO 3: (Opzionale) L’utente deve scegliere il livello di difficoltà del gioco

                int choiceExtracted;
                ChooseLevel(out choiceExtracted);


                //PUNTO 2: l'utente sceglie i numeri da giocare

                ChooseNumbers(out chosenNumbers, choiceChosen);



                //PUNTO 4: estrazione 20 numeri random non uguali.
                //COMPILA
                ExtractedNumbers(out extractedNumbers, choiceExtracted);


                //PUNTO 5 e 7: confrontare i numeri estratti con quelli scelti dall'utente
                Check(chosenNumbers, extractedNumbers, choiceChosen, choiceExtracted);
                

                Console.WriteLine(" \n *********Vuoi rigiocare? Premi********* \n" +
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

        /******METODI*****/

        //Scelta dei numeri

        private static int[] ChooseNumbers(out int[] chosenNumbers, int choice)
        {
            chosenNumbers = new int[choice];

            int count = 0;
            int num;

            do
            {

                int found = -1;
                Console.WriteLine("\n Inserisci un numero tra 1 e 90:");
                num = Convert.ToInt32(Console.ReadLine());
              

                if (num >= 1 && num <= 90) //CONTROLLO numero inserito sia entro il range corretto
                {

                    found = Array.IndexOf(chosenNumbers, num);

                    if (found == -1) //CONTROLLO che il numero non sia già stato inserito
                    {
                        chosenNumbers[count] = num;
                        count++;
                    }
                    else
                    {

                        Console.WriteLine("Numero già inserito. Inserisci nuovo numero.");

                    }

                }
                else
                {
                    Console.WriteLine("Il numero inserito è fuori dal range richiesto");

                }


            }
            while (count < choice);

                Console.WriteLine(" \n *********Numeri scelti: ********* \n");

                for (int j = 0; j < choice; j++)
                {
                    Console.WriteLine($"{chosenNumbers[j]}");

                }




            return chosenNumbers;
        }

        //Scelta della difficoltà

        private static int ChooseLevel(out int choice)
        {
            Console.WriteLine("\n *******Scegli il livello di difficoltà del gioco e digita quanti numeri vuoi estrarre:******** \n" +
            " FACILE: estrarre 70 numeri \n" +
            " MEDIO: estrarre 40 numeri \n" +
            " DIFFICILE: estrarre 20 numeri \n");


            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        //Estrazione dei numeri

        private static int[] ExtractedNumbers(out int[] extractedNumbers,  int choice) {

            extractedNumbers = new int[choice];
            int count = 0;
            int random;

            do
            {

                int found = -1;

                Random rnd = new Random();

                random = rnd.Next(1, 91);

                // CONTROLLO per vedere se, dati numeri random doppi, li scarta
                //Console.WriteLine($"\n Numeri estratti in totale: {random}");

                found = Array.IndexOf(extractedNumbers, random);

                if (found == -1)
                {
                    extractedNumbers[count] = random;
                    count++;
                }

            }

            while (count < choice);

          // controllo per vedere i numeri estratti:

            //Console.WriteLine(" \n *********numeri estratti: ********* \n");

            //for (int j = 0; j < choice; j++)
            //{
            //    Console.WriteLine($"{extractedNumbers[j]}");

            //}

            return extractedNumbers;


        }


        //Controllo della vittoria

        private static void Check(int[] chosenNumbers, int[] extractedNumbers ,  int choice1, int choice2 )
        {


            int[] finalSet = new int[choice1]; // array che viene riempito coi numeri 'vincitori'

            for(int i=0; i<choice1; i++)
            {
                for(int j=0; j<choice2; j++)
                {

                    if (chosenNumbers[i] == extractedNumbers[j])
                    {
                        finalSet[i] = chosenNumbers[i];
                    }

                }


            }

            //definisco indice per contare gli elementi diversi da zero in final set
            int numeroNonZero = 0;

            for (int k = 0; k < choice1; k++)
            {
                if ( finalSet[k]!=0)
                {
                    numeroNonZero++;
                }
                
            }

            //Ciclo per stampare il risultato

            if(numeroNonZero == 0 || numeroNonZero==1)
            {
                Console.WriteLine("\n *********Hai perso! ********* ");

            }
            else if(numeroNonZero == 2)
            {
                Console.WriteLine("\n *********Hai fatto ambo! Numeri vincenti: *********");

                for (int z = 0; z < choice1; z++) 
                {

                    if (finalSet[z] != 0)
                    {
                        Console.WriteLine($"{finalSet[z]}");
                    }

                }

            }
            else if (numeroNonZero == 3)
            {
                Console.WriteLine("\n *********Hai fatto terno!Numeri vincenti: *********");


                for (int z = 0; z < choice1; z++)
                {

                    if (finalSet[z] != 0)
                    {
                        Console.WriteLine($"{finalSet[z]}");
                    }

                }

            }
            else if (numeroNonZero == 4)
            {
                Console.WriteLine("\n *********Hai fatto quaterna! Numeri vincenti: *********");

                for (int z = 0; z < choice1; z++)
                {

                    if (finalSet[z] != 0)
                    {
                        Console.WriteLine($"{finalSet[z]}");
                    }

                }

            }
            else if (numeroNonZero == 5)
            {
                Console.WriteLine("\n *********Hai fatto cinquina! Numeri vincenti: *********");

                for (int z = 0; z < choice1; z++)
                {

                    if (finalSet[z] != 0)
                    {
                        Console.WriteLine($"{finalSet[z]}");
                    }

                }

            }

            else if(numeroNonZero > 5)
            {
                Console.WriteLine("\n *********Hai fatto Tombola! Numeri vincenti: *********");

                for (int z = 0; z < choice1; z++)
                {

                    if (finalSet[z] != 0)
                    {
                        Console.WriteLine($"{finalSet[z]}");
                    }

                }

            }
        }






    }
}
