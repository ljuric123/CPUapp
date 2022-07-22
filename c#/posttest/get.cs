using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Network


{
    class Get
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:3000/admin/all";

            client.DefaultRequestHeaders.Add("Get", "application/json");
            var httpResponse = await client.GetAsync(url);
            string content = await httpResponse.Content.ReadAsStringAsync();
            Console.WriteLine(content);


        }
    }
}