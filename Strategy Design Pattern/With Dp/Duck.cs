namespace Strategy_Design_Pattern.With_Dp
{
    internal abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }

        public void Fly()
        {
            FlyBehaviour.PerformFly();
        }
        public void Quack()
        {
            QuackBehaviour.PerformQuack();
        }
        public abstract void Diplay();

        public void Swim() => Console.WriteLine("I am Swimming");
    }
}
