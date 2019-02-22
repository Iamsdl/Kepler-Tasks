using System;

namespace BradApp
{
    public class BradApp
    {
        public static char[,] RamuriBradMatrice(char[,] a, int x, int n)
        {

            int limi = x * (x + 1) / 2, lims = (x + 1) * (x + 2) / 2 - 1;
            if (x > 1)
                a = RamuriBradMatrice(a, x - 1, n);
            for (int i = limi; i <= lims; i++)
                for (int j = (n + 1) - (i - limi); j <= (n + 1) + (i - limi); j++)
                    a[i, j] = '*';

            return a;
        }
        public static char[,] TrunchiBradMatrice(char[,] a, int n)
        {
            int l = ((n + 1) * (n + 2) / 2) + 1;
            a[l, n + 1] = '*'; a[l-1, n + 1] = '*';

            return a;
        }
        public static string ToString(char[,] a,int l,int c)
        {
            string b = "";
            for(int i=1;i<=l;i++)
            {
                for (int j = 1; j <= c; j++)
                    b = b + a[i, j];
                b = b + "\n";
            }

            return b;
        }
    }
}
