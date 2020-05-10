namespace BerlinClock.Rows
{
    internal class OneMinutesDisplayRow : DisplayRow
    {
        public OneMinutesDisplayRow(ITime time) : base(time, "Y", 4)
        {
        }

        public override string GetValue()
        {
            int countOfLampsOn = Time.Minutes % 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            int countOfLampsOff = CountOfLamps - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
