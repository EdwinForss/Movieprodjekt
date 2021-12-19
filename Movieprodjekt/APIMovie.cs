using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movieprodjekt
{
    class APIMovie
    {
        public static HttpClient client = new HttpClient();

        public static async Task Movie()
        {
            Console.Write("skriv in id till din film:");
                try
                {
                    int ID = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Fel input!");
                }

             string uri = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";

             var response = await client.GetAsync(uri);

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch
                {
                    Console.WriteLine("Fel!");
                }

          
             string responseContent = await response.Content.ReadAsStringAsync();

           
             FindById findbyid = JsonConvert.DeserializeObject<FindByID>(responseContent);

             PrintMovie();


          
                
        }

    
    }
}
