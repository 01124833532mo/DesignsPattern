namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static Methode

            GCard gCard1 = GCard.GetCard();
            GCard gCard2 = GCard.GetCard();
            GCard gCard3 = GCard.GetCard();

            Console.WriteLine(gCard1.GetHashCode());

            Console.WriteLine(gCard2.GetHashCode());
            Console.WriteLine(gCard3.GetHashCode());
            #endregion

            GCard gCard4 = GCard.SingeltonObj;
            GCard gCard5 = GCard.SingeltonObj;
            GCard gCard6 = GCard.SingeltonObj;

            Console.WriteLine(gCard4.GetHashCode());

            Console.WriteLine(gCard5.GetHashCode());
            Console.WriteLine(gCard6.GetHashCode());


        }
    }
}
