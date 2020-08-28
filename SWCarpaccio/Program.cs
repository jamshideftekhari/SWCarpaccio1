using System;

namespace SWCarpaccio
{
    class Program
    {
        static void Main(string[] args)
        {
            // make hello word console app .net core output helloworld
            //Read number of items and output number of items
            //Read number of items and price – output total price whithout state tax
            //Read state code calculate price with state tax
            //output state tax
            //Calculate and output price with discount.
            //output discont
            //claculate and output discount
            // output date and time 
            // dont stop program - iterative
            //user stop program by "E"

            // refactor protocol/user input mode price + item number
            // check for right input

            int itemNumber;
            double itemPrice;
            string stateCode;
            double totalWithTax;
            string keyValue = " ";

            Console.WriteLine("Hello let me calculate a price for you!");
            while (keyValue != "E")
            {
                //Console.WriteLine("enter number of items: ");
                //itemNumber = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter the Price: ");
                //itemPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter item number _ Price");
                string[] inputArray = Console.ReadLine().Split(' ');
                itemNumber = Convert.ToInt32(inputArray[0]);
                itemPrice = Convert.ToDouble(inputArray[1]);

                double totalWithoutTax = itemNumber * itemPrice;
                Console.WriteLine("Total without tax: " + totalWithoutTax);

                Console.WriteLine("enter state code: ");
                stateCode = Console.ReadLine();
                //double totalWithTax;
                switch (stateCode)
                {
                    case "UT":
                        totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0685);
                        Console.WriteLine("tax is 6.85%");
                        Console.WriteLine("total price with UT Tax: " + totalWithTax);
                        CalculateDiscount(totalWithTax);
                        break;
                    case "NV":
                        totalWithTax = totalWithoutTax + (totalWithoutTax * 0.08);
                        Console.WriteLine("tax is 8.00%");
                        Console.WriteLine("total price with NV Tax: " + totalWithTax);
                        CalculateDiscount(totalWithTax);
                        break;
                    case "TX":
                        totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0625);
                        Console.WriteLine("tax is 6.25%");
                        Console.WriteLine("total price with UT Tax: " + totalWithTax);
                        CalculateDiscount(totalWithTax);
                        break;
                    case "AL":
                        totalWithTax = totalWithoutTax + (totalWithoutTax * 0.04);
                        Console.WriteLine("tax is 4%");
                        Console.WriteLine("total price with NV Tax: " + totalWithTax);
                        CalculateDiscount(totalWithTax);
                        break;
                    case "CA":
                        totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0825);
                        Console.WriteLine("tax is 8.25%");
                        Console.WriteLine("total price with NV Tax: " + totalWithTax);
                        CalculateDiscount(totalWithTax);
                        break;
                    default:
                        {
                            Console.WriteLine("wrong state code ");
                            break;
                        }
                       
                }
                Console.WriteLine("Press E for exit, Enter for continue");
                keyValue = Convert.ToString(Console.ReadLine());
            }

        }

        private static void CalculateDiscount(double price)
        {
            if (1000 < price && price < 5000)
            {
                // 3% discount
                price = price - (price * 0.03);
                Console.WriteLine("Discont is: " + price*0.03);
                Console.WriteLine("price with discount " + price );
            }
            else if (5000 < price && price < 7000)
            {
                // 5% discount
                price = price - (price * 0.05);
                Console.WriteLine("Discont is: " + price * 0.05);
                Console.WriteLine("price with discount " + price);
            }
            else if (7000 < price && price < 10000)
            {
                // 7% discount
                price = price - (price * 0.07);
                Console.WriteLine("Discont is: " + price * 0.07);
                Console.WriteLine("price with discount " + price);
            }
            else if (10000 < price && price < 50000)
            {
                // 10% discount
                price = price - (price * 0.1);
                Console.WriteLine("Discont is: " + price * 0.1);
                Console.WriteLine("price with discount " + price);
            }
            else if (50000 < price)
            {
                // 15% discount
                price = price - (price * 0.15);
                Console.WriteLine("Discont is: " + price * 0.15);
                Console.WriteLine("price with discount " + price);
            }
            else
            {
                Console.WriteLine(" no discount ");
            }
            Console.WriteLine(DateTime.Now);
          //  Console.WriteLine("Press E for exit, Enter for continue");
          //  Console.Read();

        }
    }
}
