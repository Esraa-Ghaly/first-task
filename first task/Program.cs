namespace first_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of small room:");
            int Snum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of large room :");
            int Lnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cost of small room  is 25$");
            Console.WriteLine("Cost of large room  is 35$");
            int totalcost = 25 * Snum + 35 * Lnum;
            Console.WriteLine($"Total cost={totalcost}");
            Console.WriteLine("Sales tax rate is6%");
            double tax = totalcost *.06;
            double ts = totalcost + tax;
            Console.WriteLine($"Total estimate={ts}");
            Console.WriteLine("This estimate is valid for 30 days");

       
              





          





        }
    }
}
