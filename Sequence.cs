using System;

namespace finalProject2
{
    class Calculation2
    {
        public static void Sequence(int limit)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = num1 + num2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            for(int i=0;i<limit;i++)
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                Console.WriteLine(num3);
                

            }

        }
    }
}