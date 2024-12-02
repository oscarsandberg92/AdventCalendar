namespace AdventCalendar.Data
{
    public class DataProvider
    {
        private string Path { get => Directory.GetCurrentDirectory() + "../../../../../AdventCalendar.Data/Days/"; }

        public string[] GetDay1_1() => File.ReadAllLines(Path + "Day1-1.txt");
        public string[] GetDay1_2() => File.ReadAllLines(Path + "Day1-2.txt");
        public string[] GetDay2_1() => File.ReadAllLines(Path + "Day2-1.txt");
        public string[] GetDay2_2() => File.ReadAllLines(Path + "Day2-2.txt");
    }
}
