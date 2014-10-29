using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jeremiah. What door do you want to open (1,2, or 3)?");
            try
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    
                    Console.WriteLine("You won a car! Do you want to open the door? (Yes or No)");
                    string y = (Console.ReadLine()).ToLower();
                    if (y == "yes")
                        Console.WriteLine("You died in a massive explosion.");
                    else if (y == "no")
                        Console.WriteLine("You survived another day to open more \"doors\".");
                    else
                        throw new InvalidOperationException();
 

                }
                else if (x == 2)
                {
                    Console.WriteLine("You won a boat!");
                }
                else if (x == 3)
                {
                    Console.WriteLine("You die.");
                }
                else
                {
                    Console.WriteLine("Pay attention to instructions, you moron.");
                }
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine("invalid choice" + ioe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("you fucking idiot. You're not playing the game right. Im leaving. " + ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
