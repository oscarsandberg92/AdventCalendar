using AdventCalendar.Logic;

namespace AdventCalendar.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter wich day you want to run:");
            Console.Write("Day: ");
            string responseDay = Console.ReadLine() ?? throw new Exception("Input can't be null");

            Console.WriteLine($"Enter wich part of day {responseDay} you want to run:");
            Console.Write("Part: ");
            string responsePart = Console.ReadLine() ?? throw new Exception("Input can't be null");

            var client = new Client();

            client.RunPuzzle(responseDay, responsePart );
        }
    }
}
