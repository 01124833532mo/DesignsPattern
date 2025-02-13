namespace Strategy_Design_Pattern.With_Dp
{
    internal class MallardDuck : Duck
    {
        public override void Diplay()
        {
            Console.WriteLine("I am Mallard Duck");
        }
        public MallardDuck() : base(new NormalSpeedFly(), new NormalQuack())
        {

        }
    }
}
