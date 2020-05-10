namespace BerlinClock.Rows
{
    internal class FiveMinutesDisplayRow : DisplayRow
    {
        public FiveMinutesDisplayRow(ITime time) : base(time.Minutes, "Y", 11)
        {
        }

        public override string GetRowValue()
        {
            int countOfLampsOn = (NumberToDisplay - NumberToDisplay % 5) / 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            lampsOn = lampsOn.Replace("YYY", "YYR");

            int countOfLampsOff = LampsCount - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
