namespace API.Entities
{
    public class DailyScrum
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DayOfWeek { get; set; }
        public string YesterdayTaskOne { get; set; }
        public string YesterdayTaskTwo { get; set; }
        public string YesterdayTaskThree { get; set; }
        public string YesterdayTaskFour { get; set; }
        public string YesterdayTaskFive { get; set; }

        public string TodaydayTaskOne { get; set; }
        public string TodayTaskTwo { get; set; }
        public string TodayTaskThree { get; set; }
        public string TodayTaskFour { get; set; }
        public string TodayTaskFive { get; set; }
    }
}