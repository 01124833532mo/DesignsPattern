namespace Strategy_Design_Pattern.With_No_Dp
{
    internal class RubberDuck : Duck
    {
        public override void Diplay()
        {
            Console.WriteLine("Iam Rubber Duck ");
        }
        public new void Fly() => Console.WriteLine("Not Wings To Fly");

        public new void Quak()
        {
            Console.WriteLine("I am Squaking");

            Console.Beep(90, 2000);
        }
    }
}
