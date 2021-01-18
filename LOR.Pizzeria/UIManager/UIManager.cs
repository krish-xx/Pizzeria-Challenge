using LOR.Pizzeria.Common;
using LOR.Pizzeria.Toppings;
using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class UIManager
    {
        private Order order;
        private PizaFactory factory;

        public void Start(Order order)
        {
            this.order = order;

            List<PizaFactory> lstAvailableFactories = new List<PizaFactory> { new BrisbaneFactory(), new SydneyFactory() };

            string sFactoryPrompt = "";
            foreach (PizaFactory f in lstAvailableFactories)
            {
                sFactoryPrompt += "\n" + f.GetFactoryCode() + ". " + f.GetFactoryName();
            }

            Console.WriteLine("Welcome to LOR Pizzeria!");
            Console.WriteLine("Please select the store location number form list below " + sFactoryPrompt);

            string sPrompt = Console.ReadLine();
            if (sPrompt == "1")
            {
                factory = new BrisbaneFactory();
            }
            else if (sPrompt == "2")
            {
                factory = new SydneyFactory();
            }
            else
            {
                ExitNoFactory();
                return;
            }

            Console.WriteLine("Welcome to Pizzeria " + factory.GetFactoryName() + " Outlet");

            sPrompt = "1";
            while (sPrompt == "1" || sPrompt == "2" || sPrompt == "3" || sPrompt == "4")
            {
                DisplayMenu();
                sPrompt = Console.ReadLine();

                switch (sPrompt)
                {
                    case "1":
                        DisplayOrder();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        RemoveItem();
                        break;
                    case "4":
                        CheckOut();
                        break;
                    case "5":
                        CheckOut();
                        ExitMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("             LOR PIZZERIA - MAIN MENU        ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. View Current Order ");
            Console.WriteLine("2. Add New Item to Current Order ");
            Console.WriteLine("3. Remove Item from Current Order ");
            Console.WriteLine("4. Checkout and Pay ");
            Console.WriteLine("5. Exit");
            Console.WriteLine("*********************************************");
        }

        public void DisplayOrder()
        {
            order.DisplayOrder();
        }

        public void AddItem()
        {
            Console.WriteLine(factory.PromptAvailablePizzas());
            string sPrompt = Console.ReadLine();

            Pizza p = factory.GetPizza(sPrompt);
            //Pizza pTemp = factory.GetPizza(sPrompt);


            if (p != null)
            {
                //Now show cheese option
                CheeseTopping t1 = new CheeseTopping(p);
                Console.WriteLine("Do you want to add " + t1.GetToppingName() + " for additional " + t1.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                sPrompt = Console.ReadLine();
                if (sPrompt.ToUpper() == "Y")
                {
                    p = new CheeseTopping(p);
                }

                //Now show mayo option
                MayoTopping t2 = new MayoTopping(p);
                Console.WriteLine("Do you want to add " + t2.GetToppingName() + " for additional " + t2.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                sPrompt = Console.ReadLine();
                if (sPrompt.ToUpper() == "Y")
                {
                    p = new MayoTopping(p);
                }

                //Now show olive oil option
                OliveOilTopping t3 = new OliveOilTopping(p);
                Console.WriteLine("Do you want to add " + t3.GetToppingName() + " for additional " + t3.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                sPrompt = Console.ReadLine();
                if (sPrompt.ToUpper() == "Y")
                {
                    p = new OliveOilTopping(p);
                }

                order.AddToOrder(p);
                Console.WriteLine("\n\n\nItem successfully added to order.");
                order.DisplayOrder();
                Console.WriteLine("\n\n\n");

            }

        }

        public void RemoveItem()
        {
            Console.WriteLine("Enter item number to remove.");
            string spro = Console.ReadLine();
            order.RemoveFromOrder(int.Parse(spro) - 1);
            order.DisplayOrder();
            Console.WriteLine("\n\n\n");


        }

        public void CheckOut()
        {
            order.CheckoutOrder();
        }

        public void ExitMenu()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("            THANKS FOR USING LOR PIZZERIA     ");
            Console.WriteLine("                   GOOD BYE...!!!             ");
            Console.WriteLine("*********************************************");
        }

        public void ExitNoFactory()
        {
            Console.WriteLine("Outlet could not be initiated. Exiting....!!!");
        }
    }
}
