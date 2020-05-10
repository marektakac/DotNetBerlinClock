namespace BerlinClock.Rows
{
    internal class FiveMinutesDisplayRow : DisplayRow
    {
        public FiveMinutesDisplayRow(ITime time) : base(time.Minutes, "Y", 11)
        {
        }

        public override string GetRowValue()
        {
            string rowValue = base.GetRowValue().Replace("YYY", "YYR");
            return string.Concat(rowValue, GetValueOfNextRow());
        }

        protected override int GetLampsOnCount()
        {
            return (NumberToDisplay - NumberToDisplay % 5) / 5;
        }
    }
}
