using System;

namespace LabReport
{
    class Program3
    {
        static void Main()
        {
           
            for(int i = 0; i < 3; i++)
            {
                for (int j = i; j < 2; j++)
                {
                    Console.Write(" ");
                }
               // Console.WriteLine();
                for (int j = 0; j <=i; j++)
                {
                    Console.Write('*');
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }


            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < 3; j++)
                {
                    Console.Write('*');
                }
                for (int j = i; j < 2; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }


    }
    


}
