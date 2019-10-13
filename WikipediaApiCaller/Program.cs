using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();

            using (Stream stream = client.OpenRead("https://www.wikizeroo.org/index.php/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=england%20overflow"))
            using (StreamReader reader = new StreamReader(stream))
            {
                JsonSerializer ser = new JsonSerializer();
                Result result = ser.Deserialize<Result>(new JsonTextReader(reader));

                foreach (Page page in result.query.pages.Values)
                    Console.WriteLine(page.extract);
            }
        }
    }

    public class Result
    {
        public Query query { get; set; }
    }

    public class Query
    {
        public Dictionary<string, Page> pages { get; set; }
    }

    public class Page
    {
        public string extract { get; set; }
    }
}