using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Vacanze.pt3
{
    internal class Program
    {

        // Definizione di una struttura per rappresentare un punto 2D
        struct PuntoEs109
        {
            public int X;
            public int Y;

            public PuntoEs109(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // Definizione di un enum per rappresentare i livelli di priorità
        enum PrioritaEs109
        {
            Bassa,
            Media,
            Alta
        }

        // Definizione di una classe per rappresentare un Task
        class TaskEs109
        {
            public string Nome { get; set; }
            public PrioritaEs109 Priorita { get; set; }
            public PuntoEs109 Posizione { get; set; }

            public TaskEs109(string nome, PrioritaEs109 priorita, PuntoEs109 posizione)
            {
                Nome = nome;
                Priorita = priorita;
                Posizione = posizione;
            }
        }

        static void Main(string[] args)
        {

            //ARRAY E LISTE

            #region es 1 (105)
            // Creazione di un array di 5 interi
            int[] numeriEs105 = { 10, 20, 30, 40, 50 };

            // Stampa dei valori dell'array
            for (int iEs105 = 0; iEs105 < numeriEs105.Length; iEs105++)
            {
                Console.Write(numeriEs105[iEs105] + " ");
            }
            #endregion

            #region es 2 (106)
            Console.WriteLine();
            // Dichiarazione di una lista di stringhe
            List<string> listaEs106 = new List<string>();

            // Aggiunta di elementi alla lista
            listaEs106.Add("Mela");
            listaEs106.Add("Banana");
            listaEs106.Add("Arancia");

            // Stampa degli elementi della lista
            foreach (string elementoEs106 in listaEs106)
            {
                Console.Write(elementoEs106 + " + ");
            }
            #endregion

            #region es 3 (107)
            // Creazione di un array bidimensionale 3x3
            int[,] arrayEs107 = new int[3, 3]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };
            Console.WriteLine();
            // Stampa dei valori dell'array bidimensionale
            for (int iEs107 = 0; iEs107 < arrayEs107.GetLength(0); iEs107++)
            {
                for (int jEs107 = 0; jEs107 < arrayEs107.GetLength(1); jEs107++)
                {
                    Console.Write(arrayEs107[iEs107, jEs107] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region es 4 (108)
            Console.WriteLine();
            // Creazione di un array di numeri
            int[] numeriEs108 = { 10, 20, 30, 40, 50 };

            // Calcolo della somma dei valori nell'array
            int sommaEs108 = 0;
            for (int iEs108 = 0; iEs108 < numeriEs108.Length; iEs108++)
            {
                sommaEs108 += numeriEs108[iEs108];
            }

            // Calcolo della media
            double mediaEs108 = (double)sommaEs108 / numeriEs108.Length;

            // Stampa della media
            Console.WriteLine("La media dei valori è: " + mediaEs108);
            #endregion

            #region es 5 (109)
            // Creazione di una lista di oggetti Task
            List<TaskEs109> listaTaskEs109 = new List<TaskEs109>();

            // Aggiunta di oggetti Task alla lista
            listaTaskEs109.Add(new TaskEs109("Comprare cibo", PrioritaEs109.Alta, new PuntoEs109(10, 20)));
            listaTaskEs109.Add(new TaskEs109("Fare esercizio", PrioritaEs109.Media, new PuntoEs109(30, 40)));
            listaTaskEs109.Add(new TaskEs109("Studiare C#", PrioritaEs109.Bassa, new PuntoEs109(50, 60)));

            // Stampa dei task nella lista
            foreach (var taskEs109 in listaTaskEs109)
            {
                Console.WriteLine($"Task: {taskEs109.Nome}, Priorità: {taskEs109.Priorita}, Posizione: ({taskEs109.Posizione.X}, {taskEs109.Posizione.Y})");
            }
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
    }
}
