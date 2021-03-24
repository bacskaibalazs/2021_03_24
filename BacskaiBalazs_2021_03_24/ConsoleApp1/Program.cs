using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 2021_03_24
{
    class Program
    {



        static void Main(string[] args)
        {
            Tomb();
            Feladat_3();
            Feladat_4();
            Feladat_5();
            Feladat_6();
            Feladat_7();
            Feladat_8();
            Feladat_9();
            Console.ReadKey();
        }

        

        private static void Tomb()
        {
            static Random rnd = new Random();

            static int[] tomb = new int[100];

            int min = 1000;

            int max = 9999;

            for (int i = 0; i < 100; i++)
                {
                    
                    int random = rnd.Next(min, max);

                    while (random % 5 != 0)
                        {
                            random = rnd.Next(min, max);
                        }

                    tomb[i] = random;
            }
        }

        private static void Feladat_3()
        {
            Console.WriteLine();

            Console.WriteLine("Feladat 3 :");

            for (int i = 0; i < 100; i = i + 10)
                {
                    for (int j = i; j < i + 10; j++)
                        {
                            Console.Write(tomb[j] + " ");
                    
                        }

                Console.WriteLine();

                }
        }

        
        public static void Feladat_4()
        {
            Console.WriteLine();

            Console.WriteLine("Feladat4 : ");

            for (int i = 0; i < 100; i = i + 10)
                {
                    for (int j = i; j < i + 10; j++)
                        {
                            if ((j + 1) % 7 == 0)
                                {
                                    Console.Write(tomb[j] + " ");
                                }
                            else
                                {
                                    Console.Write(tomb[j] + " ");
                                }
                }

                Console.WriteLine();
            }
        }

        public static void Feladat_5()
        {
            Console.WriteLine();

            Console.WriteLine("Feladat 5 :");

            Console.WriteLine(tomb.Sum());
        }

        public static void Feladat_6()
        {
            Console.WriteLine();

            Console.WriteLine("Feladat 6 : ");

            int ossz = 0;

            int db = 0;

            for (int i = 0; i < 100; i++)
                {
                        if (tomb[i] < 5000 && tomb[i] >= 4000)
                            {
                                ossz = ossz + tomb[i];
                                db++;
                            }
                }

            double atlag = ossz / db;

            Console.WriteLine(atlag);
        }

        public static void Feladat_7()
        {
            Console.WriteLine();

            Console.WriteLine("Feladat 6 :");

            int i = 0;

            while (i < tomb.Length && tomb[i] % 65 != 0)
                {
                    i++;
                }

            Console.WriteLine("65 első többszöröse: " + tomb[i]);

            Console.WriteLine("Indexe: " + Array.IndexOf(tomb, tomb[i]));
        }

        public static void Feladat_8()
        {
            Console.WriteLine();
            Console.WriteLine("Nyolcadik Feladat:");

            int darab = 0;
            for (int i = 0; i < 100; i++)
            {
                if (tomb[i] >= 3000 && tomb[i] < 4000)
                {
                    darab++;
                }
            }
            Console.WriteLine($"{darab} db 3-massal kezdodo van");
        }

        
        public static void Feladat_9()
        {
            Console.WriteLine();

            Console.WriteLine("Kilencedik Feladat:");

            int i = 0;

            while (i < tomb.Length && tomb[i] <= 3000)
                {
                    i++;
                
        }
            Console.WriteLine("Elfogadhato junior brutto órabér indexe: " + Array.IndexOf(tomb, tomb[i]));
        }
    }
}
