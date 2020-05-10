namespace BerlinClock.Rows
{
    internal class OneHoursDisplayRow : DisplayRow
    {
        public OneHoursDisplayRow(ITime time) : base(time.Hours, "R", 4)
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
