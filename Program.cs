using System;
// use RestSharp library  to send requests to API's
using RestSharp;


namespace webAPI
{
  class Program
  {
    static void Main(string[] args){
freeGames gameList = new freeGames();
var response = gameList.request();

Console.WriteLine(response.Content);


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