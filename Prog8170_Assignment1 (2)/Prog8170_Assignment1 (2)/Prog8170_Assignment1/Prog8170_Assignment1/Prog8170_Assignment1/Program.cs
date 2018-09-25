using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170_Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width;
            // Creating instance of Rectangle class in order to pass the values to attributes that is (Length and Width).

            string length = string.Empty;

            string width = string.Empty;
            // Initializing variables for the input
            string userinput = string.Empty;
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {



                Console.WriteLine("Press 1 to Get Length of Rectangle");
                Console.WriteLine("Press 2 to Change Length of Rectangle ");
                Console.WriteLine("Press 3 to Get Width of Rectangle");
                Console.WriteLine("Press 4 to Change Width of Rectangle");
                Console.WriteLine("Press 5 to Get Parameter of Rectangle");
                Console.WriteLine("Press 6 to Get Area of Rectangle");
                Console.WriteLine("Press 7 to Exit");

                userinput = Console.ReadLine();
                // Validating values of the Width

                if (userinput == "1")
                {

                    Console.WriteLine("Length of the Rectangle is {0} ", rectangle.GetLength());
                }

                else if (userinput == "2")
                {
                    Console.WriteLine("Enter the new Length");
                    length = Console.ReadLine();

                    if ((rectlength <= 0) && (!int.TryParse(length, out rectlength)))
                    {
                        Console.WriteLine("Please enter valid length");
                    }
                    else
                    {

                        Console.WriteLine("New length is {0} ", rectangle.SetLength(rectlength));
                    }
                }

                else if (userinput == "3")
                {
                    Console.WriteLine("Width of Rectangle is {0} ", rectangle.GetWidth());
                }

                else if (userinput == "4")
                {
                    Console.WriteLine("Enter new width of Rectangle : ");
                    width = Console.ReadLine();
                    if ((rectwidth <= 0) && (!int.TryParse(width, out rectwidth)))
                    {
                        Console.WriteLine("Please enter valid width");
                    }
                    else
                    {

                        Console.WriteLine("New width of Rectangle is {0} ", rectangle.SetWidth(rectwidth));
                    }
                }
                else if (userinput == "5")
                {

                    Console.WriteLine("Perimeter of the Rectangle is {0} ", rectangle.GetPerimeter());
                }
                else if (userinput == "6")
                {

                    Console.WriteLine("Area of the Rectangle is {0} ", rectangle.GetArea());
                }
                else if (userinput == "7")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter correct input :)");
                }
            }
            
        }
    }
}
