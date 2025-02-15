namespace DecoratorDesignPattern
{
    public abstract class Decorator : Beverage
    {
        private protected Beverage _beverage;

        public Decorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }

    // Decorator 
    public class Milk : Decorator
    {

        public Milk(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }

        public override string Description => $"{_beverage.Description} With Milk";
        public override decimal Cost => _beverage.Cost + 3.9M;
    }

    public class Caramel : Decorator
    {
        private readonly Beverage _beverage;

        public Caramel(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }
        public override string Description => $"{_beverage.Description} With Caremel";
        public override decimal Cost => _beverage.Cost + 4.9M;


    }

    public class WhiteMoca : Decorator
    {
        private readonly Beverage _beverage;

        public WhiteMoca(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }
        public override string Description => $"{_beverage.Description} With With WhiteMoca";
        public override decimal Cost => _beverage.Cost + 4.9M;


    }
}
