using System;
using System.Collections.Generic;

namespace Esercizio_1_Delegates
{
    class Program
    {

        public delegate void Delegate(int value);

        public delegate void Delegate_2(double value_1, double value_2);

        static void Main(string[] args)
        {
            Es1();
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
            Es2();
            Console.WriteLine("\n-------------------------------------------------------------------------\n");
            Es3();

            Console.ReadKey();
        }

        static void Es1()
        {
            List<int> Numeri = new List<int>() { -11, -5, 0, 43, 326 };

            Delegate del_1 = (int val) => {

                Console.WriteLine("Il numero {0} è maggiore di zero", val);
            };

            Delegate del_2 = (int val) => {

                Console.WriteLine("Il numero {0} è minore di zero", val);
            };

            Delegate del_3 = (int val) => {

                Console.WriteLine("Il numero {0} è uguale a zero", val);
            };


            while (Numeri.Count != 0)
            {

                if (Numeri[0] > 0)
                {
                    del_1(Numeri[0]);
                }
                else if (Numeri[0] < 0)
                {
                    del_2(Numeri[0]);
                }
                else
                {
                    del_3(Numeri[0]);
                }

                Numeri.RemoveAt(0);
            }
        }

        static void Es2()
        {
            List<int> Numeri = new List<int>() { -5, 0, 43, };
            int n = 0;

            Delegate del_1 = (int val) => {

                n = val * val;
                Console.WriteLine("Quadrato: {0}", n);
            };

            del_1 += (int val) => {

                Console.WriteLine("Quadrato: {0} \nCubo: {1}\n", n, n*val);
            };

            while (Numeri.Count != 0)
            {
                Console.WriteLine("Numero: {0}", Numeri[0]);
                del_1.Invoke(Numeri[0]);
                
                Numeri.RemoveAt(0);
            }
        }

        static void Es3()
        {

            Delegate_2 del_1 = (double val_1, double val_2) => {

                Console.WriteLine("Somma vale: {0}\n", val_1 + val_2);
            };

            del_1 += (double val_1, double val_2) => {

                Console.WriteLine("Sottrazione vale: {0}\n", val_1 - val_2);
            };

            del_1 += (double val_1, double val_2) => {

                Console.WriteLine("Moltiplicazione vale: {0}\n", val_1 * val_2);
            };

            del_1 += (double val_1, double val_2) => {

                Console.WriteLine("Divisione vale: {0}\n", val_1 / val_2);
            };

            Console.WriteLine("Numero 1: {0} \nNumero 2: {1}", 5, 2.5);
            del_1.Invoke(5, 2.5);
        }
    }
}
