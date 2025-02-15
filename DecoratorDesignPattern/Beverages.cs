namespace DecoratorDesignPattern
{
    // Abstract Component
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = null!;
        public virtual decimal Cost { get; set; }

        public override string ToString() => $"{Description} \nCost: {Cost:c}";


    }
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso Coffee ";
            Cost = 2.5M;
        }
    }
    class MediumRoastCoffee : Beverage
    {
        public MediumRoastCoffee()
        {
            Description = "Medium Roast Coffee";
            Cost = 4.5M;
        }
    }

    class Decafe : Beverage
    {
        public Decafe()
        {
            Description = "Decafe Coffee";
            Cost = 4.0M;
        }
    }

    class DarkRoastCoffee : Beverage
    {
        public DarkRoastCoffee()
        {
            Description = "Dark Roast Coffee";
            Cost = 2.5M;
        }
    }
}
