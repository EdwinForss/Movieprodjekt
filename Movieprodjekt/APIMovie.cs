
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Movieprodjekt;
using static Movieprodjekt.MovieId;



namespace Movieprodjekt
{
    class APIMovie
    {
        public static HttpClient client = new HttpClient();

        public static async Task Movie()
        {
            Console.Clear();
            try
            {

                Console.Write("skriv in id till din film:");
                int id = Convert.ToInt32(Console.ReadLine());


                string key = Environment.GetEnvironmentVariable("6650edee15b29fdb8e34c4119315f48d");

                string uri = $"https://api.themoviedb.org/3/movie/{id}?apikey={key}";
                
                var response = await client.GetAsync(uri);

                response.EnsureSuccessStatusCode();

                Console.WriteLine(response.EnsureSuccessStatusCode());

                string responseContent = await response.Content.ReadAsStringAsync();
            
                MovieId movieId = JsonConvert.DeserializeObject<MovieId>(responseContent);

                Console.WriteLine("Här är din film med id: {0}", id);
                Console.WriteLine("Title: {0}",movieId.Title);
                Console.WriteLine("\nDescreption: {0}", movieId.Overview);
                Console.WriteLine("\nLanguage: {0}", movieId.Original_Language);
                Console.WriteLine("Runtime: {0} min", movieId.RunTime);
                Console.WriteLine("Release date: {0}", movieId.Release_Date);
                Console.WriteLine("Avreage Vote: {0}", movieId.Vote_Average);
                Console.WriteLine("Homepage: {0}", movieId.HomePage);
                Console.WriteLine("Poster adress: {0}", movieId.Poster_Path);

                
            }

            catch
            {
              await Movie();
              Console.WriteLine("Fel försök igen!");
            }




                
                
               
                    

                

          

           

             


          
                
         }

    
    }
}
