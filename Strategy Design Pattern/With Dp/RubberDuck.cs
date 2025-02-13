namespace Strategy_Design_Pattern.With_Dp
{
    internal class RubberDuck : Duck
    {
        public override void Diplay()
        {
            Console.WriteLine("I am Mallard Duck");
        }
        public RubberDuck() : base(new NoFly(), new Squaking())
        {

        }
    }
}
