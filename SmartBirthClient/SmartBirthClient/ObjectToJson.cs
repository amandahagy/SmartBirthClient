using SmartBirthClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SmartBirthClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //get();
            post();
            Console.Read();
        }

        static void post()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            User user = new User();
            user.UserCode = 33;
            user.Name = "Victor Vieira";
            user.Rg = 20345678900;
            user.Cpf = 31345678900;
            var date5 = new DateTime(1950, 1, 1, 8, 33, 00);
            user.Birth = date5;

            var json = JsonConvert.SerializeObject(user);

            StringContent content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

            System.Net.Http.HttpResponseMessage response =
                client.PostAsync("http://127.0.0.1:8080/api/User", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("User has been successfully created.");
                Console.Write("Link: " + response.Headers.Location);
            }
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
}