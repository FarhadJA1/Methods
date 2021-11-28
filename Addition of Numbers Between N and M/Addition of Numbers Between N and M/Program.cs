using System;

namespace Addition_of_Numbers_Between_N_and_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition();
        }
        static void Addition(int n = 0,int m = 0)
        {
            for (int i = n; i < m; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(n/m);
                }
            }
        }
       
    }
}
