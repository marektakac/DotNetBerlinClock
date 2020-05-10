namespace BerlinClock.Rows
{
    internal class FiveHoursPerLampDisplayRow : DisplayRow
    {
        public FiveHoursPerLampDisplayRow(ITime time) : base(time.Hours, "R", 4)
        {
        }

        protected override int GetLampsOnCount()
        {
            return (NumberToDisplay - NumberToDisplay % 5) / 5;
        }
    }
}
