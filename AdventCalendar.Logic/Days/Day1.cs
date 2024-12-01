using AdventCalendar.Data;

namespace AdventCalendar.Logic.Days
{
    public class Day1(DataProvider dataProvider)
    {
        private readonly DataProvider _dataProvider = dataProvider;

        public void RunPart1()
        {
            var data = _dataProvider.GetDay1_1();
            var lists = GetSortedNumberLists(data);
            var left = lists.Item1;
            var right = lists.Item2;

            var distance = 0;

            for (int i = 0; i < left.Count; i++)
            {
                distance += Math.Abs(left[i] - right[i]);
            }

            Console.WriteLine($"The total distance was: {distance}");
        }

        public void RunPart2() 
        { 
            var data = _dataProvider.GetDay1_2();
            var lists = GetSortedNumberLists(data);
            var left = lists.Item1;
            var right = lists.Item2;

            int similarityScore = 0;

            foreach (int number in left)
            {
                similarityScore += number * right.Count(x => x == number);
            }

            Console.WriteLine($"The similarity score is: {similarityScore}");
        }

        private (List<int>, List<int>) GetSortedNumberLists(string[] data)
        {
            var left = new List<int>();
            var right = new List<int>();

            foreach (var item in data)
            {
                var numbers = item.Replace("   ", ",").Split(',');
                try
                {
                    left.Add(int.Parse(numbers[0]));
                    right.Add(int.Parse(numbers[1]));
                }
                catch
                {
                    continue;
                }
            }

            var sortedLeft = left.OrderBy(x => x).ToList();
            var sortedRight = right.OrderBy(x => x).ToList();

            return (sortedLeft, sortedRight);
        }
    }
}
