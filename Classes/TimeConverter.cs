namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var time = Time.FromText(aTime);
            var display = new Display(time);
            return display.GetValue();
        }
    }
}
