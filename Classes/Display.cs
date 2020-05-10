namespace BerlinClock
{
    using Rows;

    internal class Display
    {
        private readonly DisplayRow firstRow;

        public Display(ITime time)
        {
            firstRow = new SecondsDisplayRow(time);
            firstRow.AddNextRow(DisplayRowType.FiveHours, time)
                    .AddNextRow(DisplayRowType.OneHours, time)
                    .AddNextRow(DisplayRowType.FiveMinutes, time)
                    .AddNextRow(DisplayRowType.OneMinutes, time);
        }

        public string GetValue()
        {
            return firstRow.GetRowValue();
        }
    }
}
