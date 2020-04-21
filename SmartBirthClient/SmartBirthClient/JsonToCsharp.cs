/*using SmartBirthClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SmartBirthClient
{
    class JsontoCsharp
    {
        static void Main(string[] args)
        {
            get();
            Console.Read();
        }

        static void get()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            System.Net.Http.HttpResponseMessage response =
                client.GetAsync("http://127.0.0.1:8080/api/User").Result;

            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;

                List<User> list =
                    JsonConvert.DeserializeObject<List<User>>(content);

                foreach (var item in list)
                {
                    Console.WriteLine("Name:" + item.Name);
                    Console.WriteLine("RG:" + item.Rg);
                    Console.WriteLine("CPF:" + item.Cpf);
                    Console.WriteLine("Birth:" + item.Birth);
                    Console.WriteLine(" ========== ");
                    Console.WriteLine("");
                }
            }
        }
    }
}*/