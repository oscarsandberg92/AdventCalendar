using AdventCalendar.Data;
using AdventCalendar.Logic.Days;

namespace AdventCalendar.Logic
{
    public class Client
    {
        private readonly DataProvider _provider = new();
        public void RunPuzzle(string day, string part)
        {
            switch (day) 
            {
                case "1":
                    var day1 = new Day1(_provider);
                    if(part == "1")
                        day1.RunPart1();
                    else
                        day1.RunPart2();
                    break;
                case "2":
                    var day2 = new Day2(_provider);
                    if (part == "1")
                        day2.RunPart1();
                    else
                        day2.RunPart2();
                    break;

                default: throw new Exception("");
            }
        }
    }
}
