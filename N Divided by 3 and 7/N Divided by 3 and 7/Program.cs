using System;

namespace N_Divided_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine(GetAnswer(n));

            
        }
        static bool GetAnswer(int n)
        {
            
            if (n%3==0 && n%7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
                

            
        }
    }
   

}

