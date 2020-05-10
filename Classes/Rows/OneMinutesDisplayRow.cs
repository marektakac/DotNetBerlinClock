namespace BerlinClock.Rows
{
    internal class OneMinutesDisplayRow : DisplayRow
    {
        public OneMinutesDisplayRow(ITime time) : base(time.Minutes, "Y", 4)
        {
        }

        public override string GetRowValue()
        {
            int countOfLampsOn = NumberToDisplay % 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            int countOfLampsOff = LampsCount - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
