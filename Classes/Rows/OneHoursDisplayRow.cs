﻿namespace BerlinClock.Rows
{
    internal class OneHoursDisplayRow : DisplayRow
    {
        public OneHoursDisplayRow(ITime time) : base(time, "R", 4)
        {
        }

        public override string GetValue()
        {
            int countOfLampsOn = Time.Hours % 5;
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            int countOfLampsOff = CountOfLamps - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string nextRowValue = GetValueOfNextRow();

            return string.Concat(lampsOn, lampsOff, nextRowValue);
        }
    }
}
