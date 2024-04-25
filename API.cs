using System;
using RestSharp;
namespace webAPI{
    // create a parent class to contain all features for API's in use.

public abstract class API{
  
RestClient client;
RestRequest APIrequest;
public RestClient response;
// set URL in child classes
 protected string url = "";
//set params in child classes
 protected string parameters = "";
 // method to request information from an API

public RestResponse request(){
  // get the client to visit the url provided
  client = new RestClient(this.url);
//Request the information that follows the parameters you set
  APIrequest = new RestRequest(this.parameters);
  // Get what the API responded with
  var response = this.client.Get(this.APIrequest);
  return response;
}
}
}
