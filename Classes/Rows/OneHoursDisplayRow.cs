namespace BerlinClock.Rows
{
    using System;

    internal class OneHoursDisplayRow : DisplayRow
    {
        public OneHoursDisplayRow(ITime time) : base(time)
        {
        }

        public override string GetValue()
        {
            throw new NotImplementedException();
        }
    }
}
