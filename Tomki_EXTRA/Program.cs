using System;

namespace Extra02
{
    class Program
    {

        static void Main(string[] args)
        {
            int run = 1;
            string[] cword;

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
                    else
                        Console.WriteLine(cword[i]);
                }


                _ = Console.ReadKey();


            }

        }
    }
}
