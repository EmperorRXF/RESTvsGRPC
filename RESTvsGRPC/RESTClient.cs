using ModelLibrary.REST;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RESTvsGRPC
{
    public class RESTClient
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> GetSmallPayloadAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return await client.GetStringAsync("http://localhost:5000/api/MeteoriteLandings");
        }

        public async Task<List<MeteoriteLanding>> GetLargePayloadAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string meteoriteLandingsString = await client.GetStringAsync("http://localhost:5000/api/MeteoriteLandings/LargePayload");

            return JsonConvert.DeserializeObject<List<MeteoriteLanding>>(meteoriteLandingsString);
        }

        public async Task<string> PostLargePayloadAsync(List<MeteoriteLanding> meteoriteLandings)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.PostAsJsonAsync("http://localhost:5000/api/MeteoriteLandings/LargePayload", meteoriteLandings);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
