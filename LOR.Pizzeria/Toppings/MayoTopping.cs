namespace LOR.Pizzeria.Toppings
{
    class MayoTopping : Topping
    {
        public MayoTopping(Pizza baseComponent)
            : base(baseComponent)
        {
            this.name = "Mayo";
            this.price = 2.0;
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
