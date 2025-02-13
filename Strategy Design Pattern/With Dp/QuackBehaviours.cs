namespace Strategy_Design_Pattern.With_Dp
{
    interface IQuackBehaviour
    {
        void PerformQuack();

    }


    class NormalQuack : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Iam Quacking");
            Console.Beep(320, 1000);
        }
    }
    class Squaking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Iam Squaking");
            Console.Beep(90, 2000);
        }
    }
}
