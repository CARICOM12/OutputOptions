using System;

namespace OutputOptions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("February has {0,10} or {1,5} days.", 28, 29);
            Console.WriteLine("March has {0,30} and April {1, 20}", 31, 30);
            Console.WriteLine("why Marina Defranchi blocked me? {0, 5}st she is too stubborn, {1,7}nd she is too TBM", 1, 2);
            Console.WriteLine("Here is 28/6: " + 28.0 / 6.0);

            int i;
            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            */
            Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
            Console.WriteLine("Here is 25*8.1: {0:#.##}", 25.222 * 8.1);

            decimal price = 3987082209.0m;
            Console.WriteLine("The variable price is {0:C}", price);
        }
    }
}
