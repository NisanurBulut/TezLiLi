using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;


namespace TezLiLi.APIHelpers
{
    public static class ApiMainHelper
    {
        public static string Token = string.Empty;
        public static Uri BaseAddress =new Uri( "http://tools.nlp.itu.edu.tr/SimpleApi");
        public static async Task<string> CallApi(string input, string tool)
        {
            Token= ConfigurationManager.AppSettings["ituPipeLineToken"];
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = BaseAddress })
            {
                //usually i make a standard request without authentication, eg: to the home page.
                //by doing this request you store some initial cookie values, that might be used in the subsequent login request and checked by the server
                var homePageResult = client.GetAsync("/");
                homePageResult.Result.EnsureSuccessStatusCode();

                var content = new FormUrlEncodedContent(new[]
                {
             new KeyValuePair<string, string>("tool", tool),
             new KeyValuePair<string, string>("input", input),
             new KeyValuePair<string, string>("token", Token),
                });
               HttpResponseMessage httpResponse = client.PostAsync(BaseAddress, content).Result;

                //will throw an exception if not successful
                httpResponse.EnsureSuccessStatusCode();
                //make the subsequent web requests using the same HttpClient object
                string result = await httpResponse.Content.ReadAsStringAsync();
                return result;
            }
        }
    }
}
