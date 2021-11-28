using System;

namespace N_is_Prime_or_Complex_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberType();
        }
        static void NumberType()
        {
            int n = 0;
            if (n/2==0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Complex Number");
            }
        }
    }
}
