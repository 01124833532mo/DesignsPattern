namespace Strategy_Design_Pattern.With_No_Dp
{
    internal abstract class Duck
    {
        public abstract void Diplay();

        public void Swim() => Console.WriteLine("I am Swimming");
        public void Fly() => Console.WriteLine("I am Flying");

        public void Quak()
        {
            Console.WriteLine("I am Quaking");

            Console.Beep(430, 1000);
        }

    }
}
