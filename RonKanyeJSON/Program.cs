using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace RonKanyeJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new Quoter(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Ron: {quote.RonQuote()}");

                Console.WriteLine("|||");
                Console.WriteLine($"Kanye; {quote.KayneQuote()}");
            }
        }
    }
}
