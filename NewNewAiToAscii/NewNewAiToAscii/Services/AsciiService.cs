using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewNewAiToAscii.Models;
using RestSharp;

namespace NewNewAiToAscii.Services
{
    public class AsciiService : IAsciiService
    {
        // the api key -- as stated
        private static readonly string API_KEY = "Af8CFiFwETICVj6MM5cJRz";

        private static readonly string PLACE_HOLDER = "This is the place holder for the eventual JSON URL link from the AiPic";
        // the complete URL for the API call
        private static readonly string URL = "https://process.filestackapi.com/" + API_KEY + "/ascii=size:70/" + PLACE_HOLDER;


        private readonly RestClient client = new RestClient();

        public string GetAscii()
        {
            RestRequest request = new RestRequest(URL);

            RestResponse response = client.Get(request);

            if (response.ResponseStatus == ResponseStatus.Completed && response.IsSuccessful)
            {
                return response.Content;
            }

            return null;
            
        }
    }
}
