using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string sku = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal totalPrice = 0;

            switch (sku)
            {
                case "A99":
                    price = 50;
                    if (quantity % 3 == 0)
                    {
                        totalPrice = CalcSpecialOfferForThreeItem(price, quantity);
                    }
                    else if(quantity % 2 == 0)
                    {
                        totalPrice = CalcSpecialOfferForTwoItem(price, quantity);
                    }
                    else
                    {
                        totalPrice += quantity * price;
                    }
                   
                    break;

                case "B15":
                    price = 30;
                    if (quantity % 3 == 0)
                    {
                        totalPrice = CalcSpecialOfferForThreeItem(price, quantity);
                    }
                    else if (quantity % 2 == 0)
                    {
                        totalPrice = CalcSpecialOfferForTwoItem(price, quantity);
                    }
                    else
                    {
                        totalPrice += quantity * price;
                    }
                    break;
                case "C40":
                    price = 60;
                    if (quantity % 3 == 0)
                    {
                        totalPrice = CalcSpecialOfferForThreeItem(price, quantity);
                    }
                    else if (quantity % 2 == 0)
                    {
                        totalPrice = CalcSpecialOfferForTwoItem(price, quantity);
                    }
                    else
                    {
                        totalPrice += quantity * price;
                    }
                    break;
                case "T34":
                    price = 99;
                    if (quantity % 3 == 0)
                    {
                        totalPrice = CalcSpecialOfferForThreeItem(price, quantity);
                    }
                    else if (quantity % 2 == 0)
                    {
                        totalPrice = CalcSpecialOfferForTwoItem(price, quantity);
                    }
                    else
                    {
                        totalPrice += quantity * price;
                    }
                    break;

                default:
                    break;
            }
        }

        private static decimal CalcSpecialOfferForThreeItem(decimal price, int quantity)
        {
            int promotionaNum = 3;
            decimal calcPromotion = (quantity / promotionaNum) * (price - (price * 0.6M));
            decimal total = (quantity * price) - calcPromotion;
            return total;
        }

        private static decimal CalcSpecialOfferForTwoItem(decimal price, int quantity)
        {
            int promotionaNum = 2;
            decimal calcPromotion = (quantity / promotionaNum) * (price - (price * 0.5M));
            decimal total = (quantity * price) - calcPromotion;
            return total;
        }
    }
}
