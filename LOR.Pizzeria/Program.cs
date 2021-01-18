using LOR.Pizzeria.Common;
using LOR.Pizzeria.Outlets;
using LOR.Pizzeria.Toppings;
using System;
using System.Collections.Generic;

namespace LOR.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            var sPrompt = "";
            PizaFactory fac;

            //Create a list of available outlets/factories, any time we can add new outlet here.
            List<PizaFactory> lstAvailableFactories = new List<PizaFactory> { new BrisbaneFactory(), new SydneyFactory() };

            //Generate a list of outlet names and numbers
            string sFactoryPrompt = "";
            foreach (PizaFactory f in lstAvailableFactories)
            {
                sFactoryPrompt += "\n" + f.GetFactoryCode() + ". " + f.GetFactoryName();
            }

            Console.WriteLine("Welcome to LOR Pizzeria!");
            Console.WriteLine("Please select the store location number form list below " + sFactoryPrompt);

            sPrompt = Console.ReadLine();
            if (sPrompt == "1")
            {
                fac = new BrisbaneFactory();
            }
            else if (sPrompt == "2")
            {
                fac = new SydneyFactory();
            }
            else
            {
                fac = null;
            }

            if (fac != null)
            {
                Console.WriteLine("\nWelcome to Pizzeria " + fac.GetFactoryName() + " Outlet");

                // Avaialbe pizza
                Console.WriteLine(fac.PromptAvailablePizzas());
                sPrompt = Console.ReadLine();

                // Base pizza without adding any extras
                Pizza.Pizza p = fac.GetPizza(sPrompt);
                Pizza.Pizza pTemp = fac.GetPizza(sPrompt);


                if (p != null)
                {
                    // Cheese option
                    CheeseTopping t1 = new CheeseTopping(pTemp);
                    Console.WriteLine("Do you want to add " + t1.GetToppingName() + " for additional " + t1.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                    sPrompt = Console.ReadLine();
                    if (sPrompt.ToUpper() == "Y")
                    {
                        p = new CheeseTopping(p);
                    }

                    //  Mayo option
                    MayoTopping t2 = new MayoTopping(pTemp);
                    Console.WriteLine("Do you want to add " + t2.GetToppingName() + " for additional " + t2.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                    sPrompt = Console.ReadLine();
                    if (sPrompt.ToUpper() == "Y")
                    {
                        p = new MayoTopping(p);
                    }

                    // Olive oil option
                    OliveOilTopping t3 = new OliveOilTopping(pTemp);
                    Console.WriteLine("Do you want to add " + t3.GetToppingName() + " for additional " + t3.GetToppingPrice() + " " + Constants.G_CURRENCY_SYMBOL + "?   Y/N");
                    sPrompt = Console.ReadLine();
                    if (sPrompt.ToUpper() == "Y")
                    {
                        p = new OliveOilTopping(p);
                    }

                    // Proces the order
                    p.Prepare();
                    p.Bake();
                    p.Cut();
                    p.Box();
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Your pizza is ready!");
                    Console.WriteLine("Preparing Bill");
                    Console.WriteLine("------------------------");

                    //Prepare the final value to show (with all aidditional options added)
                    PrintReceipt(p);
                    Console.WriteLine("===============================");
                    Console.WriteLine("Thanks for choosing Pizzeria!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid pizza selection.! Exiting....");
                }

            }
            else
            {
                Console.WriteLine("Invalid factory number.! Exiting....");
            }

        }

        private static void PrintReceipt(Pizza.Pizza product)
        {
            Console.WriteLine("Item: {0}, Price: {1}", product.GetName(), product.GetPrice());
        }
    }
}