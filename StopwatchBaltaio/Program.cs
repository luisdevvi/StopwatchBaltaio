namespace StopwatchBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds");
            Console.WriteLine("M = Minutes");
            Console.WriteLine("0s = Exit");
            Console.WriteLine("\nHow long do you want to count ?");
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finish...");
            Thread.Sleep(2000);
        }
    }
}
