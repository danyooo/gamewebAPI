using System;
using RestSharp;
namespace webAPI{
    // create a parent class to contain all features for API's in use.

public abstract class API{
RestClient client;
RestRequest APIrequest;
public RestClient response;
 protected string url = "";
//create params variable to set what you're requesting public void request(){
 protected string parameters = "";
public RestResponse request(){
  client = new RestClient(this.url);
//create a "RestRequest" Method
  APIrequest = new RestRequest(this.parameters);
  var response = this.client.Get(this.APIrequest);
  return response;
}
}
}
