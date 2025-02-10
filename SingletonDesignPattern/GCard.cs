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

        #region Property Methode
        public static GCard SingeltonObj { get; } = new GCard(123);

        #endregion

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
