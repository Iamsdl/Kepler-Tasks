using System;

namespace BradConsola
{
    class BradConsola
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numar ramuri: ");
            int n = int.Parse(Console.ReadLine());

            int l = 0;
            l = ((n + 1) * (n + 2) / 2) + 1;
            int c= 2 * n + 1;

            char[,] brad = VecMat.Matrice.Blanks(l, c);
            brad = BradApp.BradApp.RamuriBradMatrice(brad, n, n);
            brad = BradApp.BradApp.TrunchiBradMatrice(brad, n);
            VecMat.Matrice.Afisare(brad, l, c);
            //string b = BradApp.BradApp.ToString(brad, l, c);
            //Console.Write(b);
            Console.Read();
        }
    }
}