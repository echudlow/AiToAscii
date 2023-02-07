using System;
using RestSharp;
using NewNewAiToAscii.Models;

namespace NewNewAiToAscii.Services
{
    public class UpSplashService
    {
        private static readonly string API_Key = "?client_id=rQdtPB1SD5trMLrp8ZyMZM3CotXPZf5_H3--V3YzUB8";
        private static readonly string API_URL_RANDOM = "https://api.unsplash.com/photos/random/" + API_Key;

        private readonly RestClient client = new RestClient();


        public AiPic GetAiPic()
        {
            RestRequest request = new RestRequest(API_URL_RANDOM);

            RestResponse<AiPic> response = null; 

            if (response.ResponseStatus == ResponseStatus.Completed && response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                return null;
            }
            return null;
        }
    }
}
