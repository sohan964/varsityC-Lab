using System;

namespace LabReport
{
    class Program
    {
        public int x = 5; 
        private int y = 10; 
        protected int z = 15; 
        protected internal int ab = 10; 
        private protected int bc = 20;
        internal int cd = 14;

        public void Display()
        {
            Console.WriteLine(x);
        }


    }
    class class1 : Program
    {
        static void Main()
        {
            Program P1 = new Program();
            Console.WriteLine(P1.ab +" "+ P1.cd + " "+P1.x   );
            
            class1 c1 = new class1();
            c1.Display(); //accessing private member through METHOD
            Console.WriteLine(c1.z + " " + c1.bc );
            Console.ReadLine();

        }
    }


}
