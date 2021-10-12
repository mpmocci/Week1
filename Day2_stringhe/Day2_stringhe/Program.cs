using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;

/*Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte */
namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)
        {
            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /* calcolatrice.
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.*/

            bool proseguire;

            do
            {
                console.writeline("scegli un numero: ");
                int a = convert.toint32(console.readline());

                console.writeline("scegli un altro numero: ");
                int b = convert.toint32(console.readline());

                console.writeline("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = convert.toint32(console.readline());

                double result;


                switch (choice)
                {
                    case 1:
                        result = a + b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        console.writeline($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        console.writeline($"il risultato è {result}");
                        break;

                    default:
                        console.writeline("scelta non valida");
                        break;
                }

                console.writeline("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = convert.toint32(console.readline());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /*** VERSIONE ALTERNATIVA (PEGGIORE) 
             * 
             *
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            *****************/
        }

    }




}
using System;


namespace Week_1_day2
{

    class Program
    {
        static void Main(string[] args)

        {

            /**********Data una stringa e un carattere, Trovare quante volte quel carattere è contenuto nella 
                        stringa e stampare un messaggio: Il carattere CARATTERE è stato trovato X volte *********/

            //        Console.WriteLine("Inserisci una stringa: ");
            //        string stringa = Console.ReadLine();
            //        Console.WriteLine("Inserisci un carattere: ");
            //        char carattere = Console.ReadKey().KeyChar;
            //int i = 0;

            //        foreach (char a in stringa) {

            //            if (a == carattere)
            //            {
            //                i++;
            //            }
            //            else
            //            {
            //                continue;
            //            }

            //        }

            //        Console.WriteLine($"Il carattere è stato trovato {i} volta/e ");

            /**************** Calcolatrice********************************
            realizzare un programma che chiede all'utente di inserire
            due numeri e di scegliere se calcolare la somma,
            sottrazione, divisione o moltiplicazione.
            il programma stampa il risultato e chiede all'utente se
            vuole eseguire un altro calcolo.
            se l'utente sceglie di continuare, il programma chiede
            di nuovo all'utente di inserire due numeri, altrimenti
            esce dal programma.********************************************/

            bool proseguire;

            do
            {
                Console.WriteLine("scegli un numero: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice = Convert.ToInt32(Console.ReadLine());

                double result;



                switch (choice)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine($"il risultato è {result}");
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine($"il risultato è {result}");
                        break;
                    case 3:
                        result = a / b;
                        Console.WriteLine($"il risultato è {result}");
                        break;
                    case 4:
                        result = a * b;
                        Console.WriteLine($"il risultato è {result}");
                        break;

                    default:
                        Console.WriteLine("scelta non valida");
                        break;
                }

                Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
                int answer = Convert.ToInt32(Console.ReadLine());

                proseguire = (answer == 1) ? true : false;


            }
            while (proseguire == true);


            /******* Calcolatrice VERSIONE ALTERNATIVA (PEGGIORE) ******************************
              
             
            Console.WriteLine("scegli un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegli un altro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result;


            if (choice == 1)
            {
                result = a + b;
                Console.WriteLine($"il risultato è {result}");
            }
            else if (choice == 2)

            {
                result = a - b;
                Console.WriteLine($"il risultato è {result}");
            }

            else if (choice == 3)

            {
                result = a / b;
                Console.WriteLine($"il risultato è {result}");
            }


            else if (choice == 4)

            {
                result = a * b;
                Console.WriteLine($"il risultato è {result}");

            }

            Console.WriteLine("vuoi eseguire un altro calcolo? premi \n[1] per proseguire, \n[2] per interrompere.");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1) {

                Console.WriteLine("scegli un numero: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegli un altro numero: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("scegliere operazione. premi: \n[1] per addizione \n[2] per sottrazione \n[3] per divisione \n[4] per moltiplicazione");
                int choice2 = Convert.ToInt32(Console.ReadLine());



                if (choice2 == 1)
                {
                    result = c + d;
                    Console.WriteLine($"il risultato è {result}");
                }
                else if (choice2 == 2)

                {
                    result = c - d;
                    Console.WriteLine($"il risultato è {result}");
                }

                else if (choice2 == 3)

                {
                    result = c / d;
                    Console.WriteLine($"il risultato è {result}");
                }


                else if (choice2 == 4)

                {
                    result = c * d;
                    Console.WriteLine($"il risultato è {result}");

                }

            }

            else { 
                
                return;
            
            }


            **********************************************************************/
        }

    }




}
