namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int Num = int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine(Num + " is a even number.");
            }
            else
            {
                Console.WriteLine(Num + " is a odd number.");
            }
        }
    }
}