using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class Order
    {
        private List<Pizza> pizzaList = new List<Pizza>();

        public void DisplayOrder()
        {
            if (pizzaList.Count > 0)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("        CURRENT ORDER         ");
                Console.WriteLine("====================================");

                double total = 0;
                int i = 1;
                foreach (Pizza p in pizzaList)
                {
                    Console.WriteLine("#" + i.ToString() + " - " + "Item: {0}, Price: {1}", p.GetName(), p.GetPrice());
                    total += p.GetPrice();
                    i += 1;
                }

                Console.WriteLine("====================================");
                Console.WriteLine("TOTAL PAYABLE        " + total);
                Console.WriteLine("====================================");
            }
            else
            {
                Console.WriteLine("====================================");
                Console.WriteLine("        CURRENT ORDER         ");
                Console.WriteLine("====================================");
                Console.WriteLine("        NO ITEMS ADDED YET          ");
                Console.WriteLine("====================================");

            }

        }

        public void ClearOrder()
        {
            pizzaList.Clear();
        }

        public void AddToOrder(Pizza p)
        {
            pizzaList.Add(p);
        }

        public void RemoveFromOrder(int i)
        {
            if (pizzaList.Count > i)
            {
                pizzaList.RemoveAt(i);
                Console.WriteLine("\n\n\nItem successfully removed from the order.");
            }
            else
            {
                Console.WriteLine("ITEM DOES NOT EXISTS....!!!");
            }
        }

        public void CheckoutOrder()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("        PROCESSING ORDER            ");
            Console.WriteLine("====================================");

            foreach (Pizza p in pizzaList)
            {
                Console.WriteLine("\n\nPreparing " + p.GetName() + ".................");
                p.Prepare();
                p.Bake();
                p.Cut();
                p.Box();
            }
            Console.WriteLine("");
            DisplayOrder();
            pizzaList.Clear();

        }
    }
}
