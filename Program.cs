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
            Console.WriteLine($" gameID:{games[randID].id}");
            Console.WriteLine($" Game is {games[randID].title}");
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
            int randomGameID = rnd.Next(0, allfreegames.Count-1);
            printgameDetails(randomGameID,allfreegames) ;           
            // Console.WriteLine("rndID is " + randomGameID);
            // Console.WriteLine($" gameID:{allfreegames[randomGameID].id}");
            // Console.WriteLine($" Game is {allfreegames[randomGameID].title}");
            // Console.WriteLine($"On {allfreegames[randomGameID].platform}");

            // Console.WriteLine(allfreegames[randomGameID].short_description);
            // Console.WriteLine($"Link: {allfreegames[randomGameID].game_url}");
            

        
        }
    }
}
