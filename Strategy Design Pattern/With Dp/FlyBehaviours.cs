namespace Strategy_Design_Pattern.With_Dp
{
    interface IFlyBehaviour
    {
        void PerformFly();
    }

    class NoFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("No Wings To Fly ");
        }
    }


    class NormalSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("Iam Flying With Normal Speed");
        }
    }
}
