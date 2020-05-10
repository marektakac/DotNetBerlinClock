namespace BerlinClock.Rows
{
    internal class SecondsDisplayRow : DisplayRow
    {
        public SecondsDisplayRow(ITime time) : base(time, "Y", 1)
        {
        }

        public override string GetValue()
        {
            string rowValue = Time.Seconds % 2 == 0 ? ValueOn : ValueOff;

            return string.Concat(rowValue, GetValueOfNextRow());
        }
    }
}
