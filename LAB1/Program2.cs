/* perfect number means
 6 = 1 X 2 X 3
 1 + 2 + 3 = 6 */
 
using System;

namespace LabReport
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0) sum += i;
            }
            if(sum==a) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadLine();
        }


    }

}
