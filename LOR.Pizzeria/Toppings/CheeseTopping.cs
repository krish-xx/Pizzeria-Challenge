namespace LOR.Pizzeria.Toppings
{
    class CheeseTopping : Topping
    {
        public CheeseTopping(Pizza baseComponent)
            : base(baseComponent)
        {
            this.name = "Extra Cheese";
            this.price = 5.0;
        }

        public string GetToppingName()
        {
            return name;
        }
        public double GetToppingPrice()
        {
            return price;
        }
    }
}
