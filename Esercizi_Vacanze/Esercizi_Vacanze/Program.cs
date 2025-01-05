using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vacanze
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region VARIABILI
            Console.WriteLine("variabili");  //VARIABILI

            #region es 1
            int es1 = 1;
            es1 = 0;
            #endregion

            #region es 2
            string es2 = "es2";
            Console.WriteLine("concatenato a " + es2);
            #endregion

            #region es 3
            bool es3 = false;
            es3 = true;
            #endregion

            #region es 4
            double es4 = 1.11;
            #endregion

            #region es 5
            char es5 = 'a';
            #endregion

            #region es 6
            decimal euro = 5;
            #endregion

            #region es 7
            float es7 = 1.1234567f; //7 cifre decim
            double es7x = 1.1234567891011121; //14 cifre decim
            #endregion

            #region es 8
            long es8 = 800111222333444555;
            #endregion

            #region es 9
            short es9 = 32333;
            #endregion

            #region es 10
            byte es10 = 255;
            #endregion

            #region es 11
            const int es11 = 3;
            //if (es11 == 3) {es11 = 34}; non posso modificarla in quanto variabile
            #endregion

            #region es 12
            int es12 = 4; string es12x = "hello"; bool es12y = false;
            #endregion

            #region es 13
            var es13 = 5; var es13x = "hello";
            #endregion

            #region es 14
            int es14 = 15;
            int es14x = es14 * 2;
            #endregion

            #region es 15
            int es15 = 15;
            float es15float = (float)es15;
            #endregion

            #region es 16
            const string es16 = "hello";
            #endregion

            #region es 17
            DateTime es17 = DateTime.Now;
            #endregion

            #region es 18
            int es18 = 2;
            int es18x = 4;
            int somma = es18 + es18x;
            #endregion
            #endregion

            Console.WriteLine();
            Console.WriteLine("funzioni");  // FUNZIONI

            #region es 1 (19)
            SommaEs19();
            #endregion

            #region es 2 (20)
            VoidEs20();
            #endregion

            #region es 3 (21)
            string es21 = "hello";
            Es21Lenght(es21);
            #endregion

            #region es 4 (22)
            Es22("es22");
            #endregion

            #region es 5 (23)
            int[] es23 = { 1, 2, };
            Es23Array(es23);
            #endregion

            #region es 6 (24)
            
            try
            {
                // Chiamata della funzione con un esempio
                int es24 = 5;
                long es24result = Es24Fattoriale(es24);

                Console.WriteLine(es24result);

            }
            catch (ArgumentException ex)
            {
            }
            #endregion

            #region es 7 (25)
            int es25 = 4;
            bool risultato = IsEven(es25);

            #endregion

            #region es 8 (26)
            //guardare es 6 (24)
            #endregion

            #region es 9 (27)
            List<int> es27 = Es27Numbers();
            // Console.WriteLine(string.Join(", ", es27));
            #endregion

            #region es 10 (28)
            Es28Persona es28Persona = new Es28Persona { Nome = "Mario", Eta = 30 };
            Es28Persona nuovaEs28Persona = ModificaEs28Persona(es28Persona);
            #endregion

            #region es 11 (29)
            List<int> es29 = new List<int> { 1, 2, 3, 4, 5 };
            Es29ModLista(es29);

            #endregion

            #region es 12 (30)
            int es30 = 5;
            string es30result = VerificaPariDispari(es30);
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


        static string VerificaPariDispari(int es30)
        {
            if (es30 % 2 == 0)
                return "Pari";
            else
                return "Dispari";
        }

        static void Es29ModLista(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] *= 2;
            }
        }


        static Es28Persona ModificaEs28Persona(Es28Persona es28Persona)
        {
            return new Es28Persona
            {
                Nome = es28Persona.Nome.ToUpper(),
                Eta = es28Persona.Eta + 1
            };
        }
        class Es28Persona
        {
            public string Nome { get; set; }
            public int Eta { get; set; }
        }



        static List<int> Es27Numbers()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static long Es24Fattoriale(int es24)
        {
            if (es24 < 0)
            {
                throw new ArgumentException("Il fattoriale non è definito per numeri negativi");
            }

            long fattoriale = 1;

            for (int i = 1; i <= es24; i++)
            {
                fattoriale *= i;
            }

            return fattoriale;
        }

        private static void Es23Array(int[] es23)
        {
            Console.WriteLine(es23);
        }

        static void Es22 (string nome, int eta = 18)
        {
            Console.WriteLine($"Nome: {nome}, Età: {eta}");
        }

        private static void Es21Lenght(string es21)
        {
            Console.WriteLine("la lunghezza di es21 è: " + es21.Length);
        }

        private static void VoidEs20()
        {
            Console.WriteLine("es2 (20)");
        }

        private static void SommaEs19()
        {
            int es19somma = 10 + 20;
        }
    }

}
