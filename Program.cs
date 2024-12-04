namespace threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakePasta();
        } 
        
        static void MakePasta()
        {
            Console.WriteLine("Started Makeng Pasta ");

            var thread1 = new Thread(() => MakeChicken());
            var thread2 = new Thread(() => BoilSpaghetti());
            var thread3 = new Thread(() => DesignMeal());
            var thread4 = new Thread(() => TasteMeal());


            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread3.Join();
            thread4.Start();
            thread4.Join();

            Console.WriteLine("Your spaghetti is ready!");
        }

        static void MakeChicken()
        {
            Thread.Sleep(1000);
            Console.WriteLine(" Make Chicken done!");
        }

        static void BoilSpaghetti()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Boil Spaghetti done ! ");
        }

        static void DesignMeal()
        {
            Console.WriteLine("Design is being prepared");
            Thread.Sleep(6000);
            Console.WriteLine(" Design Meal Done ! ");
        }

        static void TasteMeal()
        {
            Thread.Sleep(1000);
            Console.WriteLine(" Taste Meal done ! ");
        }
    }
}
