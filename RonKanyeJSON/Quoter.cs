using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace RonKanyeJSON
{
    public class Quoter
    {
        private HttpClient _client;

        public Quoter(HttpClient client)
        {
            _client = client;
        }

        public string KayneQuote()
        {
            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonQuote()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse);

            return ronQuote[0].ToString();
        }
    }
}
