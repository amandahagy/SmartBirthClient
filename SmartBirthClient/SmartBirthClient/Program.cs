using System;

namespace SmartBirthClient
{
    class Program
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

                Console.Write(content.ToString());
            }
        }
    }
}