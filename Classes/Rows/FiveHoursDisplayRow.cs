﻿namespace BerlinClock.Rows
{
    internal class FiveHoursDisplayRow : DisplayRow
    {
        public FiveHoursDisplayRow(ITime time) : base(time.Hours, "R", 4)
        {
        }

        public override string GetRowValue()
        {
            return string.Concat(base.GetRowValue(), GetValueOfNextRow());
        }

        protected override int GetLampsOnCount()
        {
            return (NumberToDisplay - NumberToDisplay % 5) / 5;
        }
    }
}
