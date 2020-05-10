namespace BerlinClock.Rows
{
    internal class FiveMinutesDisplayRow : DisplayRow
    {
        public FiveMinutesDisplayRow(ITime time) : base(time.Minutes, "Y", 11)
        {
        }

        public override string GetRowValue()
        {
            return base.GetRowValue().Replace("YYY", "YYR");
        }

        protected override int GetLampsOnCount()
        {
            return (NumberToDisplay - NumberToDisplay % 5) / 5;
        }
    }
}
