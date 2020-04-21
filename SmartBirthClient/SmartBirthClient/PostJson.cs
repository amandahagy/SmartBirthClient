using System;
using System.Net.Http;
using System.Text;

namespace SmartBirthClient
{
    class Program
    {
        static void Main(string[] args)
        {
            post();
            Console.Read();
        }

        static void post()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            String json = "{ 'UserCode': 100,    'Name': 'Maria Magalhaes',    'Rg': 12345678901,   'Cpf': 12345678977,   'Birth': 2012-03-19T07:22Z' }";

            StringContent content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

            System.Net.Http.HttpResponseMessage response =
                client.PostAsync("http://127.0.0.1:8080/api/User", content).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("The user has been successfully created.");
                Console.Write("Link: " + response.Headers.Location);
            }
        }
    }
}