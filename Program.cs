using System;
using System.Text.Json;
// use RestSharp library  to send requests to API's
using RestSharp;

namespace webAPI
{
    class Program
    {
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
            Console.WriteLine("rndID is " + randomGameID);
            Console.WriteLine($" Game ID is {allfreegames[randomGameID].id}");
            Console.WriteLine($" Game ID is {allfreegames[randomGameID].title}");
            Console.WriteLine($" Game ID is {allfreegames[randomGameID].short_description}");
            Console.WriteLine($" Game ID is {allfreegames[randomGameID].game_url}");

        
        }
    }
}
