using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vacanze.pt2
{
    internal class Program
    {
        #region enum e strutture dichiarati
        enum GiornoSettimanaEs80
        {
            Lunedì,
            Martedì,
            Mercoledì,
            Giovedì,
            Venerdì,
            Sabato,
            Domenica
        }

        enum PrioritaTaskEs81
        {
            Bassa,
            Media,
            Alta,
            Urgente
        }

        enum OpzioneMenuEs82
        {
            A,
            B,
            C,
            Esci
        }


        struct RettangoloEs84
        {
            public double Larghezza;
            public double Altezza;

            public RettangoloEs84(double larghezza, double altezza)
            {
                Larghezza = larghezza;
                Altezza = altezza;
            }

            public double CalcolaArea()
            {
                return Larghezza * Altezza;
            }
        }

        enum TipoVeicoloEs85
        {
            Auto,
            Moto,
            Camion,
            Bicicletta,
            Autobus
        }


        #endregion
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

            #region es 4 (58)
            int[] es58 = { 1, 2, 3, 4, 5 };

            int sommaEs58 = 0;
            for (int ies58 = 0; ies58 < es58.Length; ies58++)
            {
                sommaEs58 += es58[ies58];
            }
            #endregion

            #region es 5 (59)
            List<string> es59 = new List<string> { "Ciao", "Mondo", "Esercizio", "Csharp" };

            foreach (string parola in es59)
            {
                // Parola contiene il valore corrente della lista
            }
            #endregion

            #region es 6 (60)
            int es60 = 5;
            long fattorialeEs60 = 1;

            for (int ies60 = 1; ies60 <= es60; ies60++)
            {
                fattorialeEs60 *= ies60;
            }
            #endregion

            #region es 7 (61)
            int es61 = 29;
            bool isPrimeEs61 = true;
            int i = 2;

            while (i * i <= es61)
            {
                if (es61 % i == 0)
                {
                    isPrimeEs61 = false;
                    break;
                }
                i++;
            }
            #endregion

            #region es 8 (62)
            int es62 = 20;
            int numeroEs62 = 2;

            do
            {
               //  Console.WriteLine(numeroEs62 + " ");
                numeroEs62 += 2;
            } while (numeroEs62 <= es62);
            #endregion

            #region es 9 (63)
            int es63 = 10;

            for (int ies63 = es63; ies63 >= 1; ies63--)
            {
                // Stampa il numero
            }
            #endregion

            #region es 10 (64)
            int es64 = 5;
            long prodottoEs64 = 1;
            int ies64 = 1;

            while (ies64 <= es64)
            {
                prodottoEs64 *= ies64;
                ies64++;
            }
            #endregion

            #region es 11 (65)
            List<int> es65 = new List<int> { 1, 2, 3, 4, 5 };

            for (int iEs65 = 0; iEs65 < es65.Count; iEs65++)
            {
                es65[iEs65] *= 2; // Modifica i valori della lista
            }

            // Ora es65 contiene {2, 4, 6, 8, 10}
            #endregion

            #region es 12 (66)
            int[] es66 = { 1, 2, 3, 4, 5 };
            int totaleEs66 = 0;
            int iEs66 = 0;

            do
            {
                totaleEs66 += es66[iEs66];
                iEs66++;
            } while (iEs66 < es66.Length);
            #endregion

            #region es 13 (67)
            for (int iEs67 = 1; iEs67 <= 10; iEs67++)
            {
                if (iEs67 == 5)
                {
                    break; // Interrompe il ciclo quando iEs67 è 5
                }
            }
            #endregion

            #region es 14 (68)
            int iEs68 = 0;

            while (iEs68 < 10)
            {
                iEs68++;

                if (iEs68 == 5)
                {
                    continue; // Salta il resto del ciclo quando iEs68 è 5
                }
            }
            #endregion

            #region es 15 (69)
            int es69 = 0;

            for (int iEs69 = 1; iEs69 <= 5; iEs69++)
            {
                es69 += iEs69; // Utilizza la variabile dichiarata all'esterno del ciclo
            }
            #endregion

            #region es 16 (70)
            int[] es70 = { 10, 20, 30, 40, 50 };

            for (int iEs70 = 0; iEs70 < es70.Length; iEs70++)
            {
                Console.WriteLine("Indice: "+ iEs70 +" Valore: " + es70[iEs70]);
            }
            #endregion

            #region es 17 (71)
            bool es71 = false;

            do
            {
                // La condizione verifica se il valore booleano è true
                if (es71)
                {
                    break; // Esce dal ciclo se es71 è true
                }

                es71 = true; // Modifica il valore di es71 per continuare il ciclo

            } while (!es71);
            #endregion

            #region es 18 (72)
            int es72 = 10;
            int sommaEs72 = 0;

            for (int iEs72 = 1; iEs72 <= es72; iEs72++)
            {
                if (iEs72 % 2 != 0) // Verifica se il numero è dispari
                {
                    sommaEs72 += iEs72; // Aggiunge il numero dispari alla somma
                }
            }
            #endregion

            #region es 19 (73)
            int es73 = 0;
            int sogliaEs73 = 10;

            while (es73 < sogliaEs73)
            {
                es73++; // Incrementa il valore

                // Il ciclo termina quando es73 raggiunge o supera la soglia
            }
            #endregion

            #region es 20 (74)
            List<string> es74 = new List<string> { "Ciao", "Mondo", "Esercizio", "CSharp" };
            int lunghezzaTotaleEs74 = 0;

            foreach (var strEs74 in es74)
            {
                lunghezzaTotaleEs74 += strEs74.Length; // Aggiunge la lunghezza di ogni stringa alla somma totale
            }
            #endregion

            #region es 21 (75)
            int sceltaEs75;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Opzione 1");
                Console.WriteLine("2. Opzione 2");
                Console.WriteLine("3. Esci");
                Console.Write("Scegli un'opzione: ");
                sceltaEs75 = int.Parse(Console.ReadLine());

                switch (sceltaEs75)
                {
                    case 1:
                        Console.WriteLine("Hai scelto l'opzione 1.");
                        break;
                    case 2:
                        Console.WriteLine("Hai scelto l'opzione 2.");
                        break;
                    case 3:
                        Console.WriteLine("Uscita...");
                        break;
                    default:
                        Console.WriteLine("Opzione non valida.");
                        break;
                }

            } while (sceltaEs75 != 3); // Il ciclo continua fino a quando l'utente sceglie "3" per uscire
            #endregion

            #region es 22 (76)
            for (int iEs76 = 1; iEs76 <= 20; iEs76++)
            {
                // Condizione complessa: il numero deve essere divisibile per 2 o 3
                if (iEs76 % 2 == 0 || iEs76 % 3 == 0)
                {
                   // Console.WriteLine(iEs76); // Stampa i numeri che soddisfano la condizione
                }
            }
            #endregion

            #region es 23 (77)
            int[] es77 = { 5, 10, 15, 20, 25, 30 };
            int valoreDaCercareEs77 = 20;
            int iEs77 = 0;
            bool trovatoEs77 = false;

            while (iEs77 < es77.Length)
            {
                if (es77[iEs77] == valoreDaCercareEs77)
                {
                    trovatoEs77 = true;
                    break; // Esce dal ciclo se il valore è trovato
                }
                iEs77++;
            }
            #endregion

            #region es 24 (78)
            int[] es78 = { 10, 20, 30, 40, 50 };
            int sommaEs78 = 0;

            for (int iEs78 = 0; iEs78 < es78.Length; iEs78++)
            {
                sommaEs78 += es78[iEs78]; // Aggiunge il valore dell'array alla somma totale
            }

            double mediaEs78 = (double)sommaEs78 / es78.Length; // Calcola la media
            #endregion

            #region es 25 (79)
            int[] es79Originale = { 1, 2, 3, 4, 5 };
            int[] es79Copiato = new int[es79Originale.Length];

            int iEs79 = 0;
            foreach (int valoreEs79 in es79Originale)
            {
                es79Copiato[iEs79] = valoreEs79; // Copia il valore da es79Originale a es79Copiato
                iEs79++;
            }
            #endregion

            //ENUM, STRUCT E CAST

            #region es 1 (80)
            foreach (GiornoSettimanaEs80 giornoEs80 in Enum.GetValues(typeof(GiornoSettimanaEs80)))
            {
                //Console.WriteLine(giornoEs80); // Stampa ogni giorno della settimana
            }
            #endregion

            #region es 2 (81)
            PrioritaTaskEs81 prioritaEs81 = PrioritaTaskEs81.Alta;
            #endregion

            #region es 3 (82)
            OpzioneMenuEs82 sceltaEs82 = OpzioneMenuEs82.B;

            switch (sceltaEs82)
            {
                case OpzioneMenuEs82.A:
                    Console.WriteLine("Hai scelto l'opzione A");
                    break;
                case OpzioneMenuEs82.B:
                    Console.WriteLine("Hai scelto l'opzione B");
                    break;
                case OpzioneMenuEs82.C:
                    Console.WriteLine("Hai scelto l'opzione C");
                    break;
                case OpzioneMenuEs82.Esci:
                    Console.WriteLine("Uscita dal programma...");
                    break;
                default:
                    Console.WriteLine("Opzione non valida");
                    break;
            }
            #endregion

            #region es 4 (83)
            //non so
            #endregion

            #region es 5 (84)
            RettangoloEs84 rettangoloEs84 = new RettangoloEs84(5, 3);

            double areaEs84 = rettangoloEs84.CalcolaArea();
            #endregion

            #region es 6 (85)
            TipoVeicoloEs85 veicoloEs85 = TipoVeicoloEs85.Moto;
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
