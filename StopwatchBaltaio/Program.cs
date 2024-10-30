namespace StopwatchBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
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
