namespace Blockbuster_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();
            Console.WriteLine("Welcome to GC Blockbuster!");



            Console.WriteLine("Please select a movie from the list using the given indexes: ");
            Blockbuster.PrintMovies(blockbuster.Movies);
            int input = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();

            Movie selection = blockbuster.Movies[input];
            Blockbuster.PrintInfo(selection);
            Console.WriteLine();

            Console.WriteLine("Do you want to watch the movie? Y/N");

            string reply = Console.ReadLine().ToLower();


            if (reply == "y")
            {
                bool sceneAgain = true;
                while (sceneAgain == true)
                {
                    Movie.PrintScenes(selection.Scenes);
                    Console.WriteLine();
                    {
                        Console.WriteLine("Which scene of " + selection.Title + " would you like to watch? Select 0 to " + (selection.Scenes.Count - 1));
                        int input2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(selection.Scenes[input2]);
                        Console.WriteLine();
                        Console.WriteLine("Watch another scene? Y/N");
                        string input3 = Console.ReadLine();
                        if (input3 == "y")
                        {
                            sceneAgain = true;
                        }
                        else if (input3 == "n")
                        {
                            sceneAgain = false;
                        }
                    }
                }
            }
            Console.WriteLine("Bye!");
        }
    }
}
                

            
        
    
    //blockbuster:
    //{movie, movie, movie}


    
