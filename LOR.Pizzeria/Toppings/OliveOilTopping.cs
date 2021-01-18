namespace LOR.Pizzeria.Toppings
{
    class OliveOilTopping : Topping
    {
        public OliveOilTopping(Pizza baseComponent)
            : base(baseComponent)
        {
            this.name = "Olive Oil";
            this.price = 3.0;
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
