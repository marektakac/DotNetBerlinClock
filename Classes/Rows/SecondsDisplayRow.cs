namespace BerlinClock.Rows
{
    internal class SecondsDisplayRow : DisplayRow
    {
        public SecondsDisplayRow(ITime time) : base(time.Seconds, "Y", 1)
        {
        }

        public override string GetRowValue()
        {
            string rowValue = NumberToDisplay % 2 == 0 ? ValueOn : ValueOff;

            return string.Concat(rowValue, GetValueOfNextRow());
        }

        protected override int GetLampsOnCount()
        {
            return 1;
        }
    }
}
