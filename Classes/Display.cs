namespace BerlinClock
{
    using Rows;

    internal class Display
    {
        private readonly DisplayRow firstRow;

        public Display(ITime time)
        {
            firstRow = new SecondsDisplayRow(time);
            firstRow.AddNextRow(DisplayRowType.FiveHours)
                    .AddNextRow(DisplayRowType.OneHours)
                    .AddNextRow(DisplayRowType.FiveMinutes)
                    .AddNextRow(DisplayRowType.OneMinutes);
        }

        public string GetValue()
        {
            return firstRow.GetValue();
        }
    }
}
