using Strategy_Design_Pattern.With_Dp;

namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();

            mallardDuck.Diplay();
            mallardDuck.Swim();
            mallardDuck.Quack();
            mallardDuck.Fly();

            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine();

            RubberDuck rubberDuck = new RubberDuck();

            rubberDuck.Diplay();
            rubberDuck.Swim();
            rubberDuck.Fly();
            rubberDuck.Quack();


            Console.WriteLine("================================");
            Console.WriteLine("*********** Hunting Mode On ***********");
            Console.WriteLine("================================");

            mallardDuck.Fly();

        }
    }
}
