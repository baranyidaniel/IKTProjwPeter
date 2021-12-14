using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace index.cs
{
    class Program
    {
        public static int[] ev = new int[3500];
        public static int[] het = new int[3500];
        public static string[] datum = new string[3500];
        public static int[] otos = new int[3500];
        public static string[] otos_nyeremeny = new string[3500];
        public static int[] negyes = new int[3500];
        public static string[] negyes_nyeremeny = new string[3500];
        public static int[] harmas = new int[3500];
        public static string[] harmas_nyeremeny = new string[3500];
        public static int[] kettes = new int[3500];
        public static string[] kettes_nyeremeny = new string[3500];
        public static int[,] nyeroszamok = new int[3500, 3500];
        public static int db = 0;
        static void Main(string[] args)
        {
            beolvas();
            legkisebb();
            Console.ReadKey();
        }

        private static void legkisebb()
        {
            int[] legkisebb = new int[3500];

            for (int i = 0; i < db; i++)
            {

            }
        }

        private static void beolvas()
        {
            try
            {
                StreamReader be = new StreamReader("otos.csv");
                string[] darab = new string[3500];
                be.ReadLine();
                while (!be.EndOfStream)
                {
                    string egysor = be.ReadLine();
                    darab = egysor.Split(';');

                    ev[db] = Convert.ToInt32(darab[0]);
                    het[db] = Convert.ToInt32(darab[1]);
                    datum[db] = darab[2];
                    otos[db] = Convert.ToInt32(darab[3]);
                    otos_nyeremeny[db] = darab[4];
                    negyes[db] = Convert.ToInt32(darab[5]);
                    negyes_nyeremeny[db] = darab[6];
                    harmas[db] = Convert.ToInt32(darab[7]);
                    harmas_nyeremeny[db] = darab[8];
                    kettes[db] = Convert.ToInt32(darab[9]);
                    kettes_nyeremeny[db] = darab[10];
                    nyeroszamok[db, 0] = Convert.ToInt32(darab[11]);
                    nyeroszamok[db, 1] = Convert.ToInt32(darab[12]);
                    nyeroszamok[db, 2] = Convert.ToInt32(darab[13]);
                    nyeroszamok[db, 3] = Convert.ToInt32(darab[14]);
                    nyeroszamok[db, 4] = Convert.ToInt32(darab[15]);

                    db++;
                }
                be.Close();
                Console.WriteLine($"Beolvasott sorok: {db}");
                Console.WriteLine($"Előző heti nyerőszámok {nyeroszamok[0, 0]}, {nyeroszamok[0, 1]}, {nyeroszamok[0, 2]}, {nyeroszamok[0, 3]}, {nyeroszamok[0, 4]}");
                Console.WriteLine($"Múlt heti nyerőszámok {nyeroszamok[1, 0]}, {nyeroszamok[1, 1]}, {nyeroszamok[1, 2]}, {nyeroszamok[1, 3]}, {nyeroszamok[1, 4]}");
            }
            catch (IOException)
            {
                Console.WriteLine("nem lyo :(");
            }
        }
    }
}
