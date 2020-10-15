using System;

namespace Extra02
{
    class Program
    {

        static void Main(string[] args)
        {
            int run = 1;
            string[] cword;
            
            int[] numbers = new int[5];

            while (run == 1)
            {
                Console.WriteLine("Hello and welcome to BOGOL");

                Console.WriteLine("Quit by writing 'quit'!");

                string echo = Console.ReadLine();

                Console.Clear();

                cword = echo.Split(' ');

                for (int i = 0; i < cword.Length; i++)
                {
                    if (cword[i].Contains("quit"))
                    {
                        run = 0;
                        Console.WriteLine("Press any key to quit");
                    }                       
                }

                int numberToStore = Int32.Parse(cword[3]);
                numbers[0] = numberToStore;

                Console.WriteLine("variable a now has the value: " + numbers[0]);

                _ = Console.ReadKey();
            }

        }
    }
}
