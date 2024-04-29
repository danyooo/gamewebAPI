using System;
using System.Text.Json;
// use RestSharp library  to send requests to API's
using RestSharp;

namespace webAPI
{
    class Program
    {
        public static void printgameDetails(int randID, List<gameData> games)
        {
            Console.WriteLine($"gameID:{games[randID].id}");
            Console.WriteLine($"Game is {games[randID].title}");
            Console.WriteLine($"On {games[randID].platform}");
            Console.WriteLine($"released on {games[randID].release_date}");
            Console.WriteLine(games[randID].short_description);
            Console.WriteLine($"Link: {games[randID].game_url}");

        }
        static void Main(string[] args)
        {
            freeGames gameList = new freeGames();
            var response = gameList.request();

            // Console.WriteLine(response.Content);
            // create an instance of random
            var rnd = new Random();
            // create a list object to deserialize a random gameTitle from
            var allfreegames = JsonSerializer.Deserialize<List<gameData>>(response.Content);
            //set a random value to be seet to grab a random games data
            // TODO: Find an easier way to print all this data out? I.e [randomGameID].content
            int randomGameID = rnd.Next(0, allfreegames.Count - 1);
            printgameDetails(randomGameID, allfreegames);

            // create a user
            user user = new user();
            // create a list for user's inputs
            List<char> userCMD = new List<char>();
            Console.WriteLine("type 'run' to find a new game!");

            while (user.cmd == "")
            {

                user.readInput();
                user.submitCMD(userCMD);
                // once user's command is selected break the loop
                if (!user.cmd.Equals(""))
                {
                    // if the user types run find another random game
                    if (user.cmd.Equals("run"))
                    {
                         //divider
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("\nfinding new game");
                        randomGameID = rnd.Next(0, allfreegames.Count - 1);
                        printgameDetails(randomGameID, allfreegames);

                        Console.WriteLine(" type 'exit' to cancel the program");
                        Console.WriteLine("type 'run' to find another game!");
                        //divider
                        Console.WriteLine("------------------------------");
                        //clear the user's previously typed command and  the list (that merges what the user typed)
                        userCMD.Clear();
                        user.cmd = "";
                    }
                    // if the user doesn't exit or run, then they mistyped
                    else if (!user.cmd.Equals("run") && !user.cmd.Equals("exit"))
                    {
                        Console.WriteLine("Oops, you mistyped!, you said:" + user.cmd);
                        Console.WriteLine("type 'run' to find another game!");
                        Console.WriteLine("type 'exit' to cancel the program");
                        //clear the user's previously typed command and  the list (that merges what the user typed)
                        userCMD.Clear();
                        user.cmd = "";
                    }
                    // if the user types exit stop the program
                    if (user.cmd.Equals("exit"))
                    {
                        break;
                    }
                    // if the user typed "run" then search for a new random game
                }
            }


        }
    }
}
