using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace NewNewAiToAscii.Models
{
    public class AiPic
    {
        // the text being used the pic a particular picture
        public string Text { get; set; } 
        // the original picture
        public string Pic { get; set; } 
        // dictionary returning list of different URLs - looking to use small pic for now
        public Dictionary<string, string> URLs { get; set; } = new Dictionary<string, string>(); 
    }
}
