using System;

namespace Carppacio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // make hello word console app .net core output helloworld
            //Read number of items and output number of items
            //Read number of items and price – output total price whithout state tax
            // changing in visual studio
            
            // add some tset test
            Console.WriteLine("Hello World!");
            Console.WriteLine("number of items");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("price? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your input: " + number);
            Console.WriteLine("your price input: " + price);

            double totalPrice = number * price;
            Console.WriteLine("total price is: " + totalPrice);

            //Read state code calculate price with state tax
            //output state tax
            Console.WriteLine("state code? :");
            string stateCode = Console.ReadLine();
            switch (stateCode)
            {
                case "NV":
                    Console.WriteLine("Nevada state code is 8%");
                    double priceWithTax = totalPrice + totalPrice * 0.08;
                    Console.WriteLine("price with tax: " + priceWithTax);
                    return;
                case "UT":
                    return;

                default:
                    return;

            }


            //Calculate and output price with discount.
            //output discont
            //claculate and output discount
            // output date and time 
            // dont stop program - iterative
            //user stop program by "E"

            // refactor protocol/user input mode price + item number
            // check for right input


        }
    }
}
