using System;
using RestSharp;
using NewNewAiToAscii.Models;

namespace NewNewAiToAscii.Services
{
    public class UpSplashService
    {
        // the API Key -- as stated
        private static readonly string API_Key = "?client_id=rQdtPB1SD5trMLrp8ZyMZM3CotXPZf5_H3--V3YzUB8";
        // starting off with a random picture to get things working
        private static readonly string API_URL_RANDOM = "https://api.unsplash.com/photos/random/" + API_Key;

        private readonly RestClient client = new RestClient();


        public string GetAiPic()
        {
            RestRequest request = new RestRequest(API_URL_RANDOM);

            // need to read the documentation so that we can get this returning what we're trying to return
            RestResponse response = client.Get(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                return null;
            }
            
        }
    }
}
