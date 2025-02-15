namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage Coffee = new Espresso();

            Console.WriteLine(Coffee);

            Milk CoffeWithMilk = new Milk(Coffee); // can not to create class Coffee With Milk
            Console.WriteLine(CoffeWithMilk);

            Caramel CoffeeWithMilkWithCaramel = new Caramel(CoffeWithMilk);
            Console.WriteLine(CoffeeWithMilkWithCaramel);

            WhiteMoca CoffeeWithMilkWithCaramelWithWhiteMoca = new WhiteMoca(CoffeWithMilk);
            Console.WriteLine(CoffeeWithMilkWithCaramel);
        }

    }
}
