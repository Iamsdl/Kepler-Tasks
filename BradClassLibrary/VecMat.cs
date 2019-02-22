using System;

namespace VecMat
{
    public  class Matrice
    {
        public static void Afisare(int[,] a, int l, int c)
        {
            for (int i = 1; i <= l; i++)
            {
                for (int j = 1; j <= c; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
        public static void Afisare(char[,] a, int l, int c)
        {
            for (int i = 1; i <= l; i++)
            {
                for (int j = 1; j <= c; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
        public static int[,] Zeros(int n, int m)
        {
            int[,] a = new int[n + 1, m + 1];
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = 0;
                }
            return a;
        }
        public static char[,] Blanks(int n, int m)
        {
            char[,] a = new char[n + 1, m + 1];
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = ' ';
                }
            return a;
        }
    }
}
