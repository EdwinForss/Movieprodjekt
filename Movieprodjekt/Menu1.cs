using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieprodjekt
{
    class Menu1
    {
        public static async Task PrintFirstMenu()
        {
            Console.WriteLine("Välj vad du vill göra:");
            Console.WriteLine("1)Sök efter film med ID");
            Console.WriteLine("2)avsluta pogrammet");

            int userInput = Convert.ToInt32(Console.ReadLine());

            try
            {

      
             switch(userInput)
             {
                case 1:

                        await APIMovie.Movie().ConfigureAwait(false);
                        Menu1.StartmenuChoice();

                        break;

                case 2:
                        Console.WriteLine("Hejdå!");

                    int delay = 200;
                    System.Threading.Thread.Sleep(delay);

                    break;

                    
                                
             }
            
            }
            catch
            {
                Console.WriteLine("Fel! försök igen");
                
            }
        }
        public static void StartmenuChoice()
        {
            throw new NotImplementedException();
        }

    }


}
