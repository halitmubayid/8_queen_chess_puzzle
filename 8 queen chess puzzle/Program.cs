using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_queen_chess_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime ilkan = DateTime.Now;
            int[,] dizi = new int[8, 8];
            int sayac = 0;
            sifirlama(dizi);
            for (int i = 0; i < 8; i++)
            {
                dizi[i, 0] = 1;
                dizi = yerlesme(dizi, i, 0);

                int[,] y1 = new int[8, 8];
                yedekle(dizi, y1);

                for (int j = 0; j < 8; j++)
                {
                    if (dizi[j, 1] == 0)
                    {
                        dizi[j, 1] = 1;
                        dizi = yerlesme(dizi, j, 1);
                        /////////////
                        int[,] y2 = new int[8, 8];
                        yedekle(dizi, y2);


                        for (int k = 0; k < 8; k++)
                        {
                            if (dizi[k, 2] == 0)
                            {
                                dizi[k, 2] = 1;
                                dizi = yerlesme(dizi, k, 2);
                                /////////////
                                int[,] y3 = new int[8, 8];
                                yedekle(dizi, y3);
                                for (int l = 0; l < 8; l++)
                                {
                                    if (dizi[l, 3] == 0)
                                    {
                                        dizi[l, 3] = 1;
                                        dizi = yerlesme(dizi, l, 3);
                                        /////////////
                                        int[,] y4 = new int[8, 8];
                                        yedekle(dizi, y4);
                                        for (int m = 0; m < 8; m++)
                                        {
                                            if (dizi[m, 4] == 0)
                                            {
                                                dizi[m, 4] = 1;
                                                dizi = yerlesme(dizi, m, 4);
                                                /////////////
                                                int[,] y5 = new int[8, 8];
                                                yedekle(dizi, y5);
                                                for (int n = 0; n < 8; n++)
                                                {
                                                    if (dizi[n, 5] == 0)
                                                    {
                                                        dizi[n, 5] = 1;
                                                        dizi = yerlesme(dizi, n, 5);
                                                        /////////////
                                                        int[,] y6 = new int[8, 8];
                                                        yedekle(dizi, y6);
                                                        for (int o = 0; o < 8; o++)
                                                        {
                                                            if (dizi[o, 6] == 0)
                                                            {
                                                                dizi[o, 6] = 1;
                                                                dizi = yerlesme(dizi, o, 6);
                                                                /////////////
                                                                int[,] y7 = new int[8, 8];
                                                                yedekle(dizi, y7);
                                                                for (int p = 0; p < 8; p++)
                                                                {
                                                                    if (dizi[p, 7] == 0)
                                                                    {
                                                                        dizi[p, 7] = 1;
                                                                        dizi = yerlesme(dizi, p, 7);
                                                                        yaz(dizi);
                                                                        sayac++;
                                                                        yedekle(y7, dizi);
                                                                    }//if o
                                                                }//o


                                                                yedekle(y6, dizi);
                                                            }//if o
                                                        }//o


                                                        yedekle(y5, dizi);
                                                    }//if n
                                                }//n


                                                yedekle(y4, dizi);
                                            }//if m
                                        }//m


                                        yedekle(y3, dizi);
                                    }//if l
                                }//l


                                yedekle(y2, dizi);
                            }//if k
                        }//k


                        yedekle(y1, dizi);
                    }//if j
                }//j
                sifirlama(dizi);
            }//i
            Console.WriteLine(sayac);
            DateTime miliondan = DateTime.Now;

            TimeSpan sure = miliondan.Subtract(ilkan);

            Console.WriteLine(sure.TotalMilliseconds);
            Console.WriteLine(sure.TotalSeconds);
            Console.ReadLine();
        }//mine

        private static void yaz(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    if (dizi[i, j] == 2)
                        dizi[i, j] = 0;
                    Console.Write(" " + dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }//yaz
        private static int[,] yedekle(int[,] x, int[,] y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    y[i, j] = x[i, j];
                }
            }
            return y;
        }//yedekleme
        private static int[,] sifirlama(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = 0;
                }
            }
            return dizi;
        }//sifirlama
        private static int[,] yerlesme(int[,] dizi, int x, int y)
        {
            int x1 = x;
            int y1 = y;

            for (int i = y; i < dizi.GetLength(1); i++)
            {
                if (dizi[x, i] == 0)
                {
                    dizi[x, i] = 2;
                }
                x++;
                if (x == 8)
                {
                    break;
                }
            }

            x = x1;
            y = y1;

            for (int i = y; i >= 0; i--)
            {
                if (dizi[x, i] == 0)
                {
                    dizi[x, i] = 2;
                }
                x--;
                if (x < 0)
                {
                    break;
                }
            }

            x = x1;
            y = y1;

            for (int i = y; i < dizi.GetLength(1); i++)
            {
                if (dizi[x, i] == 0)
                {
                    dizi[x, i] = 2;

                }
                x--;
                if (x < 0)
                {
                    break;
                }
            }

            x = x1;
            y = y1;

            for (int i = y; i >= 0; i--)
            {
                if (dizi[x, i] == 0)
                {
                    dizi[x, i] = 2;

                }
                x++;
                if (x == 8)
                {
                    break;
                }
            }

            x = x1;
            y = y1;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                if (dizi[x, i] == 0)
                    dizi[x, i] = 2;
            }

            x = x1;
            y = y1;

            for (int i = 0; i < dizi.GetLength(1); i++)
            {
                if (dizi[i, y] == 0)
                    dizi[i, y] = 2;
            }

            return dizi;
        }//yerlesme 
    }//class
}
/*private static void yaz(int[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.Write(" " + dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }//yaz*/