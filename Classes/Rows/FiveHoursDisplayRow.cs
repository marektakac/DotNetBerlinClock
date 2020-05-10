namespace BerlinClock.Rows
{
    internal class FiveHoursDisplayRow : DisplayRow
    {
        public FiveHoursDisplayRow(ITime time) : base(time, "R", 4)
        {
        }

        public override string GetValue()
        {
            int countOfLampsOn = (Time.Hours - Time.Hours % 5) / 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            int countOfLampsOff = CountOfLamps - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
