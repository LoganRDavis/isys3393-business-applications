using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxValue = 0.095;
            const double fruitSaladPrice = 9.95;
            const double pastaSaladPrice = 12.00;
            const double smoothiePrice = 4.95;
            const double fruitJuicePrice = 3.95;
            const double cupCakePrice = 3.00;
            const double shortCakePrice = 6.00;

            Console.WriteLine("********************************** MENU **********************************");
            Console.WriteLine("Fruits Salad : " + fruitSaladPrice.ToString("C"));
            Console.WriteLine("Pasta Salad : " + pastaSaladPrice.ToString("C"));
            Console.WriteLine("Smoothie : " + smoothiePrice.ToString("C"));
            Console.WriteLine("Fruit Juice : " + fruitJuicePrice.ToString("C"));
            Console.WriteLine("Cup Cake : " + cupCakePrice.ToString("C"));
            Console.WriteLine("Short Cake : " + shortCakePrice.ToString("C"));
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("**************************** ENTER YOUR ORDER ***************************");

            try
            {
                Console.WriteLine("How many Fruits Salad --- " + fruitSaladPrice.ToString("C") + " ?");
                int fruitSalads = int.Parse(Console.ReadLine());

                Console.WriteLine("How many Pasta Salad --- " + pastaSaladPrice.ToString("C") + " ?");
                int pastaSalads = int.Parse(Console.ReadLine());

                Console.WriteLine("How many Smoothie --- " + smoothiePrice.ToString("C") + " ?");
                int smoothies = int.Parse(Console.ReadLine());

                Console.WriteLine("How many Fruit Juice --- " + fruitJuicePrice.ToString("C") + " ?");
                int fruitJuices = int.Parse(Console.ReadLine());

                Console.WriteLine("How many Cup Cake --- " + cupCakePrice.ToString("C") + " ?");
                int cupCakes = int.Parse(Console.ReadLine());

                Console.WriteLine("How many short cake --- " + shortCakePrice.ToString("C") + " ?");
                int shortCakes = int.Parse(Console.ReadLine());
                Console.WriteLine("*************************************************************************");

                double subtotal =
                    fruitSalads * fruitSaladPrice +
                    pastaSalads * pastaSaladPrice +
                    smoothies * smoothiePrice +
                    fruitJuices * fruitJuicePrice +
                    cupCakes * cupCakePrice +
                    shortCakes * shortCakePrice;

                double taxCost = subtotal * taxValue;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("SubTotal Costs: " + subtotal.ToString("C"));
                Console.WriteLine("Tax: " + taxCost.ToString("C"));
                Console.WriteLine("Total Costs: " + (subtotal + taxCost).ToString("C"));
            } catch
            {
                Console.WriteLine(
                    "\n*************************************************************************" +
                    "\nAn ERROR has occurred." +
                    "\nMake sure you enter a valid whole number for your quantities." +
                    "\n*************************************************************************"
                    );
            } finally
            {
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
