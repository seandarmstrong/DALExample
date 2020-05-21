using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsDemo.DataAccessLayer.APIClient
{
    public class JokeApiClient : IJokeAPIClient
    {
        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.icndb.com");
            return client;
        }

        public JokeList GetListOfTenRandomJokes()
        {
            var client = CreateHttpClient();
            var response = client.GetAsync("jokes/random/10").Result;
            var jokes = response.Content.ReadAsAsync<JokeList>().Result;
            return jokes;
        }
    }
}
