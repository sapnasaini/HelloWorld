using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace HelloWorld
{
    /// <summary>
    ///     Hello World Console Application
    /// </summary>
    class HelloWorldConApp : IHelloWorldConApp
    {
        private static string[] arguments;

        private static void Main(string[] args)
        {
            HelloWorldConApp HelloApp = new HelloWorldConApp();
            HelloApp.Run(arguments);

        }

        /// <summary>
        ///     Run the main Hello World Console Application
        /// </summary>
        /// <param name="arguments">The command line arguments.</param>

        public void Run(string[] arguments)
        {
            HttpClient cons = new HttpClient();
            cons.BaseAddress = new Uri("http://localhost:64359/");
            cons.DefaultRequestHeaders.Accept.Clear();
            cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HelloWorldServiceResponse(cons).Wait();
        }
        static async Task HelloWorldServiceResponse(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/helloworld");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {

                    Console.WriteLine("\n");
                    Console.WriteLine("---------------------Calling Get Operation------------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("Please see below message returned by Business service");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(await res.Content.ReadAsStringAsync());
                    Console.ReadLine();
                }
            }
        }



    }
}


