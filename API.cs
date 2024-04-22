using System;
using RestSharp;
namespace webAPI{
    // create a parent class to contain all features for API's in use.

public abstract class API{
virtual string url = "";
//create params variable to set what you're requesting
virtual string params = "";
 public void request(){
var client = new RestClient(this.url);
var APIrequest = new RestRequest(this.params);
var response = this.client.Get(this.APIrequest);
return this.response;
}
}


}