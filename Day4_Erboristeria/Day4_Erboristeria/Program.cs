using System;

namespace Week1_day4
{
    class Program
    {
        static void Main(string[] args)
        {

            /************************
             *I prodotti trattati da un'erboristeria sono memorizzati in 4 vettori paralleli.
            codici -> codice di ciascun prodotto (ogni codice è una stringa)
            nomi -> nome del prodotto (stringa)
            classi -> tipologia di prodotto (cosmetici, integratori, infusi...)
            prezzi -> prezzo del prodotto
            Caricati i vettori (almeno due prodotti per classe), sviluppare le seguenti richieste:
            Realizzare un programma che, all'accesso, stampa un menu in cui chiede all'utente di scegliere 
            cosa vuole fare.
            1. stampare i dati relativi al prodotto di prezzo massimo
            2. stampare i dati relativi a un determinato prodotto il cui codice è fornito in input
            3. stampare tutti i prodotti di una categoria
            4. TODO I prezzi stanno subendo un AUMENTO. Aggiornare il prezzo di un prodotto. 
            5. TODO stampa della media dei prezzi di una categoria fornita in input
            6. TODO stampa dei dati relativi ai prodotti con prezzo compreso in una
                certa fascia, i cui estremi sono forniti in input   
            q. uscire
             * **************************************/

            #region

            string[] codice = new string[6] { "c1", "c2", "c3", "c4", "c5", "c6" };
            string[] nome = new string[6] { "supradyn", "polase", "rossetto", "smalto", "tisana energizzante", "tisana rilassante" };
            string[] categoria = new string[6] { "integratore", "integratore", "cosmetico", "cosmetico", "infuso", "infuso" };
            double[] prezzo = new double[6] { 7.99, 13.4, 4.30, 2.99, 3.74, 5 };

            bool exit = true;

            do
            {
                Console.WriteLine("\n *******Menù******** \n Scegli un'opzione \n" +
                    "[1] Stampare i dati relativi al prodotto di prezzo massimo \n" +
                    "[2] Stampare i dati relativi a un determinato prodotto \n" +
                    "[3] Stampare tutti i prodotti di una data categoria\n" +
                    "[4] Aggiornare il prezzo di un prodotto \n" +
                    "[5] Premere q per uscire \n" +
                    "\n");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':

                        double max = 0.0;
                        int index = 0;
                        for (int i = 0; i < prezzo.Length; i++)
                        {
                            if (prezzo[i] > max)
                            {
                                max = prezzo[i];
                                index = i;
                            }
                        }

                        Console.WriteLine($"\nDati relativi al prodotto con prezzo massimo:\n" +
                                          $"\tCodice: \t{codice[index]}\n" +
                                          $"\tNome: \t\t{nome[index]}\n" +
                                          $"\tCategoria: \t{categoria[index]}\n" +
                                          $"\tPrezzo: \t{prezzo[index]} ");

                        break;

                    case '2':

                        string ChosenCode = GetChosenCode(codice);

                        if (ChosenCode != null)
                        {

                            for (int j = 0; j < codice.Length; j++)
                            {
                                if (codice[j] == ChosenCode)
                                {
                                    Console.WriteLine($"\nDati relativi al prodotto selezionato:\n" +
                                                      $"\tCodice: \t{codice[j]}\n" +
                                                      $"\tNome: \t\t{nome[j]}\n" +
                                                      $"\tCategoria: \t{categoria[j]}\n" +
                                                      $"\tPrezzo: \t{prezzo[j]} ");
                                }
                            }
                        }


                        break;

                    case '3':
                        //chiedo allo user di quale categoria vuole vedere i prodotti
                        //se l'utente sceglie una categoria esistente, si mandano in stampa i prodotti
                        //altrimenti richiedo di inserire la categoria


                        GetCategories(categoria);

                        string ChosenCategory = GetChosenCategory(categoria);

                        if (ChosenCategory != null)
                        {

                            for (int k = 0; k < categoria.Length; k++)
                            {
                                if (categoria[k] == ChosenCategory)
                                {
                                    Console.WriteLine($"Prodotto: \t\t{nome[k]}\n");
                                }
                            }
                        }


                        break;

                    case '4':


                        break;

                    case 'q':
                        exit = false;
                        break;
                }

            }

            while (exit);





            #endregion

        }

        private static string GetChosenCode(string[] productsCodes)
        {
            string code = null;
            bool codeExists = false;

            while (!codeExists)
            {


                Console.WriteLine("Inserire il codice del prodotto:");
                code = Console.ReadLine();

                for (int i = 0; i < productsCodes.Length; i++)
                {
                    if (productsCodes[i] == code)
                    {
                        codeExists = true;
                        return code;
                    }
                }

            }

            return code;
        }


        private static string GetChosenCategory(string[] productsCategory)
        {
            string category = null;
            bool categoryExists = false;

            while (!categoryExists)
            {


                Console.WriteLine("\nInserire la categoria scelta:");
                category = Console.ReadLine();

                for (int i = 0; i < productsCategory.Length; i++)
                {
                    if (productsCategory[i] == category)
                    {
                        categoryExists = true;
                        return category;
                    }
                }

            }

            return category;
        }


        private static void GetCategories(string[] categories)
        {

            string[] storeCategories = new string[categories.Length];
            int count = 0;

            for (int j = 0; j < storeCategories.Length; j++)
            {
                int found = -1;
                found = Array.IndexOf(storeCategories, categories[j]);

                if (found == -1)
                {
                    storeCategories[count] = categories[j];
                    count++;
                }

            }


            Array.Resize(ref storeCategories, count);

            foreach (string c in storeCategories)
            {

                Console.WriteLine($"\n \n{c}");

            }
        }





    }
}
