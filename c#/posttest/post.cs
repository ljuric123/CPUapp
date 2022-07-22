using System;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Network


{
    class Config
    {
        public string email { get; set; }
        public string password { get; set; }

    }
    class Post
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:3000/admin/all";

          var json = new Config
          {
              email = "novo@mail.com",
              password = "dasdasdasdas"
          };

          string jsonString = JsonSerializer.Serialize(json);

          Console.WriteLine(jsonString);


          var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
          var httpResponse = await client.PostAsync(url, httpContent);
        }
    }
}