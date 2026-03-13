namespace Exercise_10__While_Loops_First_Practice 
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Menu set up
            Console.Write("Select a valid option below between 1-4");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("**************");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Menu: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("1 - New Game");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("2 - Load Game");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("3 - Options");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("4 - Quit");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("**************");
            Console.WriteLine();
            Console.WriteLine();
    
            int userInput;
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Write("Creating new game");
                Console.WriteLine();
            }

            else if (userInput == 2)
            {
                Console.WriteLine("Loading game...");
                Console.WriteLine();
            }

            else if (userInput == 3) 
            {
                Console.Write("Loading options");
                Console.WriteLine();
            }

           while ( userInput == 4)
           {
                Console.Write("Quitting Game");
                Console.WriteLine();
                userInput = int.Parse(Console.ReadLine());
           }
      
           while (userInput > 4 || userInput < 1) 
           {
                Console.Write("Invalid option");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Select a valid option below between 1-4");
                Console.WriteLine();
                userInput = int.Parse(Console.ReadLine());
           }

            if (userInput == 1)
            {
                Console.Write("Creating new game");
                Console.WriteLine();
            }

            else if (userInput == 2)
            {
                Console.WriteLine("Loading game...");
                Console.WriteLine();
            }

            else if (userInput == 3) //if last if change else if to else or something
            {
                Console.Write("Loading options");
                Console.WriteLine();
            }

            while (userInput == 4)
            {
                Console.Write("Quitting Game");
                Console.WriteLine();
                userInput = int.Parse(Console.ReadLine());
            }
        }
    }
}


