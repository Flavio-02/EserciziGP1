using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vacanze.pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ALGEBRA DI BOOL

            #region es 1 (31)
            int es31 = 5;
            if (es31 % 2 == 0)
               // "Pari"
               ;
            else
                // "Dispari"
                ;
            #endregion

            #region es 2 (32)
            int es32=50;
            if (es32 < 13)
              // "Bambino"
                    ;
            else if (es32 >= 13 && es32 < 18)
               //"Adolescente"
                    ;
            else if (es32 >= 18 && es32 < 65)
               //"Adulto"
                    ;
            else
              // "Anziano"
                    ;
            #endregion

            #region es 3 (33)
            int es33 = 25;
            bool risultato = es33 > 18 && es33 < 65;
            #endregion

            #region es 4 (34)
            int es34 = 25;
            bool risultatoEs34 = es34 < 10 || es34 > 20;
            #endregion

            #region es 5 (35)
            bool es35 = false;
            bool risultatoEs35 = !es35;
            #endregion

            #region es 6 (36)
            bool es36 = true;

            if (es36)
                ;
            else
                ;
            #endregion

            #region es 7 (37)
            bool es37 = true;

            if (es37) ;
            else if (!es37) ;
            else;
            #endregion

            #region es 8 (38)
            bool es38 = true;

            switch (es38)
            {
                case true:
                    //Console.WriteLine("vero");
                    break;
                case false:
                   // Console.WriteLine("falso");
                    break;
            }
            #endregion

            #region es 9 (39)
            int es39 = 15;

            if (es39 > 10 && es39 < 20) ;
            else;
            #endregion

            #region es 10 (40)
            int es40 = 25;
            string risultatoEs40 = es40 >= 18 ? "Adulto" : "Minorenne";
            #endregion

            #region es 11 (41)
           int es41 = 15;

            if (es41 < 10) ;
            // Il numero è minore di 10
            else if (es41 >= 10 && es41 < 20) ;
            // Il numero è compreso tra 10 e 19
            else if (es41 >= 20 && es41 < 30) ;
            // Il numero è compreso tra 20 e 29
            else;
            // Il numero è 30 o maggiore
            #endregion

            #region es 12 (42)
            int es42a = 10, es42b = 20;

            if (es42a > es42b)
            {
                // es42a è maggiore
            }
            else
            {
                // es42b è maggiore
            }
            #endregion

            #region es 13 (43)
            string es43 = "";

            if (string.IsNullOrEmpty(es43))
            {
                // La stringa è vuota o nulla
            }
            else
            {
                // La stringa non è vuota e non è nulla
            }
            #endregion

            #region es 14 (44)
            int es44 = 2024;

            if ((es44 % 4 == 0 && es44 % 100 != 0) || es44 % 400 == 0)
            {
                // L'anno è bisestile
            }
            else
            {
                // L'anno non è bisestile
            }
            #endregion

            #region es 15 (45)
            string es45 = "Ciao, come stai?";

            if (es45.Contains("come"))
            {
                // La stringa contiene la sottostringa "come"
            }
            else
            {
                // La stringa non contiene la sottostringa "come"
            }
            #endregion

            #region es 16 (46)
            int[] es46 = { 1, 2, 3, 4, 5 };

            if (es46.Contains(3))
            {
                // L'array contiene l'elemento 3
            }
            else
            {
                // L'array non contiene l'elemento 3
            }
            #endregion

            #region es 17 (47)
            int es47 = -5;

            string risultatoEs47 = DeterminasegnoEs47(es47);

            #endregion

            #region es 18 (48)
            int es48 = 3; //3 = mercoledì

            string giornoEs48 = DeterminaGiornoEs48(es48);
            #endregion

            #region es 19 (49)
            int es49 = 15;

            if (es49 % 3 == 0 && es49 % 5 == 0)
            {
                //Il numero è divisibile per 3 e 5
            }
            else
            {
                //Il numero non è divisibile per 3 e 5
            }
            #endregion

            #region es 20 (50)
            bool es50 = true;

            if (es50)
            {
                //Il valore è true
            }
            else
            {
                //Il valore è false
            }
            #endregion

            #region es 21 (51)
            string es51 = "ciao";

            switch (es51)
            {
                case "ciao":
                    // La stringa è "ciao"
                    break;
                case "hello":
                    // La stringa è "hello"
                    break;
                case "hola":
                    // La stringa è "hola"
                    break;
                default:
                    // La stringa non corrisponde a nessun caso
                    break;
            }
            #endregion

            #region es 22 (52)
                int[] es52 = { };

                if (es52.Length == 0)
                {
                    //L'array è vuoto
                }
                else
                {
                    //L'array non è vuoto
                }
            #endregion

            #region es 23 (53)
            int es53 = 7;

            if (IsNumeroPrimoEs53(es53))
            {
                // Il numero è primo
            }
            else
            {
                // Il numero non è primo
            }
            #endregion

            #region es 24 (54)
            string es54 = "anna";

            if (IsPalindromaEs54(es54))
            {
                // La parola è palindroma
            }
            else
            {
                // La parola non è palindroma
            }
            #endregion

            //LOOP

            #region es 1 (55)
            for (int es55 = 1; es55 <= 10; es55++)
            {
                Console.Write(es55 + " ");
            }
            #endregion

            #region es 2 (56)
            int es56 = 50;

            while (es56 < 100)
            {
                es56 += 10;
                // Incrementa il valore di es56 di 10 ad ogni ciclo
            }
            #endregion

            #region es 3 (57)
            int es57 = 1;

            do
            {
                Console.Write("Inserisci un numero maggiore di 0: ");
              //    es57 = int.Parse(Console.ReadLine());
            } while (es57 <= 0);
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion






        }
        static bool IsPalindromaEs54(string parola)
        {
            string inversa = new string(parola.Reverse().ToArray());
            return parola == inversa;
        }
        static bool IsNumeroPrimoEs53(int es53)
        {
            if (es53 <= 1)
                return false;

            for (int i = 2; i * i <= es53; i++)
            {
                if (es53 % i == 0)
                    return false;
            }

            return true;
        }

        static string DeterminaGiornoEs48(int giorno)
        {
            string risultatoEs48;

            switch (giorno)
            {
                case 1:
                    risultatoEs48 = "Lunedì";
                    break;
                case 2:
                    risultatoEs48 = "Martedì";
                    break;
                case 3:
                    risultatoEs48 = "Mercoledì";
                    break;
                case 4:
                    risultatoEs48 = "Giovedì";
                    break;
                case 5:
                    risultatoEs48 = "Venerdì";
                    break;
                case 6:
                    risultatoEs48 = "Sabato";
                    break;
                case 7:
                    risultatoEs48 = "Domenica";
                    break;
                default:
                    risultatoEs48 = "Numero non valido";
                    break;
            }

            return risultatoEs48;
        }



        static string DeterminasegnoEs47(int numero)
        {
            if (numero > 0)
                return "Positivo";
            else if (numero < 0)
                return "Negativo";
            else
                return "Zero";
        }

    }
}
