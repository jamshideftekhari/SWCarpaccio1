using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceCalculator.Model
{
    public static class StatePriceCalculator
    {
        // create model class med properties and methods 

        //public static int ItemNumber { get; set; }
        //public static double ItemPrice { get; set; }
        public static string StateCode { get; set; }
       // public static double DiscountRange { get; set; }

        public static double Calulate(int number, double price)
        {
            double totalWithTax = 0;
            double totalWithoutTax = number * price;

            switch (StateCode)
            {
                case "UT":
                    totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0685);
                    CalculateDiscount(totalWithTax);
                    break;
                case "NV":
                    totalWithTax = totalWithoutTax + (totalWithoutTax * 0.08);
                    CalculateDiscount(totalWithTax);
                    break;
                case "TX":
                    totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0625);
                    CalculateDiscount(totalWithTax);
                    break;
                case "AL":
                    totalWithTax = totalWithoutTax + (totalWithoutTax * 0.04);
                    CalculateDiscount(totalWithTax);
                    break;
                case "CA":
                    totalWithTax = totalWithoutTax + (totalWithoutTax * 0.0825);
                    CalculateDiscount(totalWithTax);
                    break;
                default:
                    {
                        
                        break;
                    }

            }


            return totalWithTax;
        }

        private static double CalculateDiscount(double discountPrice)
        {
            if (1000 < discountPrice && discountPrice < 5000)
            {
                // 3% discount
                discountPrice = discountPrice - (discountPrice * 0.03);
              
            }
            else if (5000 < discountPrice && discountPrice < 7000)
            {
                // 5% discount
                discountPrice = discountPrice - (discountPrice * 0.05);
              
            }
            else if (7000 < discountPrice && discountPrice < 10000)
            {
                // 7% discount
                discountPrice = discountPrice - (discountPrice * 0.07);
            }
            else if (10000 < discountPrice && discountPrice < 50000)
            {
                // 10% discount
                discountPrice = discountPrice - (discountPrice * 0.1);
                
            }
            else if (50000 < discountPrice)
            {
                // 15% discount
                discountPrice = discountPrice - (discountPrice * 0.15);
               
            }
            else
            {
                discountPrice=-1;
            }

            return discountPrice;

        }
    }
}
