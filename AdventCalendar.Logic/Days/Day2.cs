using AdventCalendar.Data;

namespace AdventCalendar.Logic.Days
{
    public class Day2(DataProvider dataProvider)
    {
        private readonly DataProvider _dataProvider = dataProvider;

        public void RunPart1()
        {
            var data = _dataProvider.GetDay2_1();

            var reports = data
                           .Select(line => line.Split(' ').Select(int.Parse).ToList())
                           .ToList();
            var safeReports = reports.Count(r => IsSafe(r));

            Console.WriteLine(safeReports);
        }

        public void RunPart2()
        {
            var data = _dataProvider.GetDay2_1();
            var reports = data
                           .Select(line => line.Split(' ').Select(int.Parse).ToList())
                           .ToList();
            var safeReports = reports.Count(r => IsSafeWithDampener(r));

            Console.WriteLine(safeReports);
        }

        private bool IsSafe(List<int> sequence)
        {
            bool? ascending = null;

            for (int i = 1; i < sequence.Count; i++)
            {
                int diff = sequence[i] - sequence[i - 1];

                if (Math.Abs(diff) < 1 || Math.Abs(diff) > 3)
                    return false;

                if (ascending == null)
                {
                    if (diff > 0)
                        ascending = true;
                    else if (diff < 0)
                        ascending = false;
                }
                else
                {
                    if ((ascending == true && diff < 0) || (ascending == false && diff > 0))
                        return false;
                }
            }

            return true;
        }

        private bool IsSafeWithDampener(List<int> levels)
        {
            if (IsSafe(levels)) return true;

            for (int i = 0; i < levels.Count; i++)
            {
                var modifiedLevels = levels.Where((_, index) => index != i).ToList();
                if (IsSafe(modifiedLevels)) return true;
            }

            return false;
        }
    }
}
