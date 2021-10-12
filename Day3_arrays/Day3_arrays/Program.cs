using System;

namespace Week1_day_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /**************************Scrivere un programma che chiede all'utente di inserire il suo codice di ingresso e la password.
Il programma deve andare avanti finché l'utente non inserisce codice d'adesione (es.1020304) e password (es. 1234.)
L'utente può fare max 3 tentativi. Al quarto tentativo, non può più inserire i dati e compare un messaggio "Account bloccato". 
Se invece il login ha successo, compare: "Login effettuato".*****************/
            #region
            //    int codice;
            //    int pwd;
            //    int a = 1;
            //    bool controllo = false;


            //do
            //{
            //    Console.WriteLine("Inserire il codice di ingresso:");
            //    codice = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Inserire la password:");
            //    pwd = Convert.ToInt32(Console.ReadLine());

            //    if (codice == 1020304 && pwd == 1234)
            //    {
            //        Console.WriteLine("LOGIN EFFETTUATO");
            //        controllo = true;
            //        return;
            //    }

            //    else
            //    {


            //            Console.WriteLine("ACCESSO NEGATO");
            //            a++;    
            //    }

            //}

            //while ( controllo == false  &&  a < 4);


            //if (controllo == false)
            //{

            //    Console.WriteLine("ACCOUNT BLOCCATO");
            //}

            #endregion





            /***************************ARRAYS************************************************/
            /****** Dato un array di 5 interi, verificare che gli elementi siano in ordine crescente.**********/

            #region

            //int[] array1 = new int[] { 1, 2, 3, 4, 6 };
            //int[] array2 = new int[] { 9, 5, 4, 5, 6 };


            //for (int i = 0; i < (array2.Length - 1); i++)
            //{
            //    if (array2[i] < array2[i + 1])
            //    {
            //        continue;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Gli elementi dell'array non sono in ordine crescente");
            //        return;
            //    }

            //}


            //    Console.WriteLine(" Gli elementi dell'array sono in ordine crescente.");


            #endregion


            /******************Dato un array di 5 interi, ordinare gli elementi in ordine crescente.**********************************/
            #region

            //int[] array1 = new int[] { 1, 2, 3, 4, 6 };
            //int[] array2 = new int[] { 9, 5, 4, 3, 6 };
            //int a;


            //for (int i = 0; i < array2.Length; i++)
            //{
            //    for (int j = 0; j < (array2.Length - 1); j++)
            //    {
            //        if (array2[j] > array2[j + 1])
            //        {
            //            a = array2[j];
            //            array2[j] = array2[j + 1];
            //            array2[j + 1] = a;
            //        }

            //        else
            //        {
            //            continue;
            //        }


            //    }

            //}

            //for (int k = 0; k < array2.Length; k++)
            //{
            //    Console.WriteLine($" {array2[k]} ");
            //}

            #endregion

            /********************Data una stringa, verificare se questa è palindroma***********************************************/

            #region

            //char[] parola1 = { 'o', 't', 't', 'o' };
            //char[] parola2 = { 'p', 'i', 'a', 't', 't', 'o' };


            //for (int i = 0; i < parola1.Length /2; i++)
            //{
            //    if (parola1[i] == parola1[parola1.Length - 1 - i])
            //    {
            //        continue;

            //    }
            //    else
            //    {

            //        Console.WriteLine("La parola non è palindroma.");
            //        return;
            //    }


            //}

            //Console.WriteLine("La parola è palindroma.");



            #endregion


        }
    }
}

