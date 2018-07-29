using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string HeSaid = "Hello";

            switch (HeSaid)
            {
                case "Hello":
                    Console.WriteLine("He Said Hello");
                    break;
                case "Bye":
                    Console.WriteLine("He Said Bye");
                    break;
                case "Yes":
                    Console.WriteLine("He Said Yes");
                    break;

                default:

                    Console.WriteLine("He didn't say anything");
                    break;
            }
         

              
                      
                
          
          
            

Console.ReadKey();

        }
    }
    }
}
