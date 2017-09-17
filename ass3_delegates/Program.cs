using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    public delegate float OrderDelegate(float TypeofTax, int Count);

    class Program
    {
        
        static void Main(string[] args)
        {
            OrderDelegate retailOrder,wholeSaleOrder,k12Order;
            retailOrder = RetailOrder;
            wholeSaleOrder = WholesaleOrder;
            k12Order = retailOrder + wholeSaleOrder;
            int choice;
            do
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Enter the quantity of product:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What order would you like to place: \n1.Retail \n2.Wholesale \n3.K12");
                int Ans = Convert.ToInt32(Console.ReadLine());

                if (Ans == 1)
                {
                    float total = retailOrder((float)12.5, quantity);
                    Console.WriteLine("Total amount to be paid : {0}", total);
                }
                else if (Ans == 2)
                {
                    float total = wholeSaleOrder((float)6.56, quantity);
                    Console.WriteLine("Total amount to be paid : {0}", total);
                }
                else
                {
                    float total = k12Order((float)2.5, quantity);
                    Console.WriteLine("Total amount to be paid : {0}", total);

                }

                Console.WriteLine("Do you want to continue: \n1.Yes \n 2.No ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice == 1);
            
        }

        public static float RetailOrder(float retailTax, int orderCount)
        {
            float total = retailTax * (float)orderCount;
            return total;

        }

        public static float WholesaleOrder(float InventoryTax, int orderCount)
        {
            float total = InventoryTax * (float)orderCount;
            return total;

        }

        
    }
}
