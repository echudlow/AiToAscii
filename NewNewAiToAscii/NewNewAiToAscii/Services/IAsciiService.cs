using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewNewAiToAscii.Models;

namespace NewNewAiToAscii.Services
{
    public interface IAsciiService
    {
        // for capturing the entire object from the API
        string GetAscii();
    }
}
