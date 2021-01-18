using System.Collections.Generic;

namespace LOR.Pizzeria
{
    public abstract class Pizza
    {
        public abstract string GetCode();

        public abstract string GetName();
        
        public abstract double GetPrice();
        
        public abstract List<string> GetIngediants();
        
        public abstract string GetIngediantsToShow();
        
        public abstract void Prepare();
        
        public abstract void Bake();
        
        public abstract void Cut();
        
        public abstract void Box();
    }
}
