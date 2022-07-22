using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace posttest


{
    class Config
    {
        public string email { get; set; }
        public string password { get; set; }

    }

    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var url = "http://localhost:3000/admin/all";

            //  var request = WebRequest.Create(url);
            //  request.Method = "GET";
            //
            //  using var webResponse = request.GetResponse();
            //  using var webStream = webResponse.GetResponseStream();
            //
            //  using var reader = new StreamReader(webStream);
            //  var data = reader.ReadToEnd();
            //
            //  Console.WriteLine(data);


          var json = new Config
          {
              email = "novo@mail.com",
              password = "dasdasdasdas"
          };

          string jsonString = JsonSerializer.Serialize(json);

          Console.WriteLine(jsonString);


          var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
          var httpResponse = await client.PostAsync(url, httpContent);
//            client.DefaultRequestHeaders.Add("Get", "application/json");
//            var httpResponse = await client.GetAsync(url);
//            string content = await httpResponse.Content.ReadAsStringAsync();
//            Console.WriteLine(content);


        }
    }
}