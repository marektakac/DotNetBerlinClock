namespace BerlinClock.Rows
{
    internal class FiveHoursDisplayRow : DisplayRow
    {
        public FiveHoursDisplayRow(ITime time) : base(time.Hours, "R", 4)
        {
        }

        protected override int GetLampsOnCount()
        {
            return (NumberToDisplay - NumberToDisplay % 5) / 5;
        }
    }
}
