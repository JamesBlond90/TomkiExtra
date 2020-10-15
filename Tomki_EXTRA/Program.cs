using System;

namespace Extra02
{
    class Program
    {

        static void Main(string[] args)
        {
            int run = 1;

            while (run == 1)
            {
                Console.WriteLine("Hello and welcome to BOGOL");
                Console.WriteLine("Quit by writing 'quit'!");

                string echo = Console.ReadLine();

                Console.Clear();

                if (echo == "quit")
                {
                    run = 0;
                }

                Console.WriteLine(echo);


                Console.WriteLine("Press any key to quit");

                Console.ReadKey();
            }




        }
    }
}
