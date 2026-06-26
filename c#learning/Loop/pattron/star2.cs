using System;

namespace csharplearn
{
    class starprint
    {
        
        static void Main()
        {

            int n ;
            for (int i = 5; i>= 1; i--)
            {
                for (int j =0; j<=i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}