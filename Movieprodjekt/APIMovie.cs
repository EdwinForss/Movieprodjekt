
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Movieprodjekt
{
    class APIMovie
    {
        public static HttpClient client = new HttpClient();

        public static async Task Movie()
        {
            
            Console.Write("skriv in id till din film:");
            string key = Environment.GetEnvironmentVariable("API_KEY");
            try
            {
              int id = Convert.ToInt32(Console.ReadLine());

             string uri = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";

             var response = await client.GetAsync(uri);

                    response.EnsureSuccessStatusCode();

             string responseContent = await response.Content.ReadAsStringAsync();
            
             FindByID findbyid = JsonConvert.DeserializeObject<FindByID>(responseContent);

                Console.WriteLine("Title: {0}", Title);
                Console.WriteLine("\nDescreption: {0}", Overview);
                Console.WriteLine("\nLanguage: {0}", Original_Language);
                Console.WriteLine("Runtime: {0} min", RunTime);
                Console.WriteLine("Release date: {0}", Release_Date);
                ShowAllGenres();
                Console.WriteLine("Avreage Vote: {0}", Vote_Average);
                Console.WriteLine("Homepage: {0}", HomePage);
                Console.WriteLine("Poster adress: {0}", Poster_Path);
            }


            catch
            {
              Console.WriteLine("Fel försök igen!");

            }

                



                
                
               
                    

                

          

           

             


          
                
        }

    
    }
}
