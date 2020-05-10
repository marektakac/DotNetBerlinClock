namespace BerlinClock.Rows
{
    internal class FiveMinutesDisplayRow : DisplayRow
    {
        public FiveMinutesDisplayRow(ITime time) : base(time, "Y", 11)
        {
        }

        public override string GetValue()
        {
            int countOfLampsOn = (Time.Minutes - Time.Minutes % 5) / 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            lampsOn = lampsOn.Replace("YYY", "YYR");

            int countOfLampsOff = CountOfLamps - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
