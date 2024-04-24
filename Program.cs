using System;
// use RestSharp library  to send requests to API's
using RestSharp;
using System.Text.Json;


namespace webAPI
{
  class Program
  {
    static void Main(string[] args)
    {
      freeGames gameList = new freeGames();
      var response = gameList.request();

      Console.WriteLine(response.Content);
      //deserialize
      string jsonString =
          """
          [
            {
              "id":540,
              "title":"Overwatch 2",
              "thumbnail":"https:\/\/www.freetogame.com\/g\/540\/thumbnail.jpg",
              "short_description":"A hero-focused first-person team shooter from Blizzard Entertainment.",
              "game_url":"https:\/\/www.freetogame.com\/open\/overwatch-2",
              "genre":"Shooter",
              "platform":"PC (Windows)",
              "publisher":"Activision Blizzard",
              "developer":"Blizzard Entertainment",
              "release_date":"2022-10-04",
              "freetogame_profile_url":"https:\/\/www.freetogame.com\/overwatch-2"
            }
          ]
          
          """;
          // create a list object to deserialize
      List<gameData> allfreegames = JsonSerializer.Deserialize<List<gameData>>(jsonString);
      Console.WriteLine(" dataaaaa " + allfreegames[0].title);
      // foreach (var item in allfreegames)
      // {
      //   Console.WriteLine("id:{0}", "title:{bee}", item.id, item.title);
      // }

      // create a new Request 
      //     var restClient = new RestClient("https://www.freetogame.com/api");

      // var RestRequest = new RestRequest("https://www.freetogame.com/api/games");
      // var response = restClient.Get(RestRequest);
      // Console.WriteLine(response.Content.ToString());
      //create a new testClass object to test recieving JSON data
      // RestRequest.AddJsonBody(JSONoutput);
    }
  }
}