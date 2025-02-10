namespace SingletonDesignPattern
{
    public class GCard
    {
        public int Data { get; set; }


        //Make Constractor Acsses Modifier is "Private"
        private GCard(int data)
        {

            Data = data;

        }

        public static GCard SingeltonObj { get; } = new GCard(123);

        #region Static Methode
        private static GCard singltonOBJ = new GCard(123);

        static GCard()
        {
            //singltonOBJ = new GCard(123);

        }
        public static GCard GetCard()
        {

            return singltonOBJ;

        }
        #endregion
    }
}
