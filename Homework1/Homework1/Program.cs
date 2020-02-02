using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SalesTax = .085;//8.5%
            string itemname;
            int amount;
            double price;

            Console.WriteLine("What is the name of the product you are trying to purchase");
            itemname = Console.ReadLine();

            Console.WriteLine("How many " + itemname + " do you want to buy?");
            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the price for each" + itemname + "?");
            price = double.Parse(Console.ReadLine());

            double subtotal = price * amount;
            double salestax = SalesTax * subtotal;
            double salestotal = subtotal + salestax;

            Console.WriteLine("Your subtotal for your bill is" + subtotal.ToString("C") + "\nYour sales tax for your bill is" + salestax.ToString("C") + "\nYour total for your bill is" + salestotal.ToString("C"));

            Console.WriteLine("Press any key to conntinue....");

            Console.ReadLine();

          


        }
       
    }
}
