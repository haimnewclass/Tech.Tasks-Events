using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Tech.Tasks_Events.Core
{
    public class HTTP
    {
        public async Task<string> GetRandom()
        {
            string str = "";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://www.randomnumberapi.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync(@"/api/v1.0/random?min=100&max=1000&count=1");
                if (response.IsSuccessStatusCode)
                {
                    str = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

            }

            return str;
        }
    }
}
