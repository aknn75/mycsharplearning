using System;
//using System.Runtime.Intrinsics.X86;

namespace csharplearn
{
    class pattornn
    {
        static void Main(){
            int n=5;

            for( int r =1; r<=n; r++)
            {
                for (int s = 1; s<=n-r; s++)
                {
                    Console.Write(" ");

                }
                for(int s =1; s <= 2 * r - 1; s++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            
        }
    }
}