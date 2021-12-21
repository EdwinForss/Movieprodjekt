using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieprodjekt
{
    class Menu1
    {
        public static void PrintFirstMenu()
        {
            Console.WriteLine("Välj vad du vill göra:");
            Console.WriteLine("1)Sök efter film med ID");
            Console.WriteLine("2)avsluta pogrammet");

        }

        public static void UserChoice()
        {
            float x = float.Parse(Console.ReadLine());
            switch(x)
            {
                case '1':

                 APIMovie.Movie();


                    break;

                case '2':


                    int delay = 200;
                    System.Threading.Thread.Sleep(delay);

                    break;
            }
        }
        
    }


}
