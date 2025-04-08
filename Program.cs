using System;

namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica= new int[100];
            for(int i=0;i<100;i++)
            {
                tablica[i]=i;
                Console.WriteLine(i);
            }
        }
    }
}
