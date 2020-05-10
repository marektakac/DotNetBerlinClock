namespace BerlinClock.Rows
{
    using System;

    internal class SecondsDisplayRow : DisplayRow
    {
        public SecondsDisplayRow(ITime time) : base(time.Seconds, "Y", 1)
        {
        }

        public override string GetRowValue()
        {
            return NumberToDisplay % 2 == 0 ? ValueOn : ValueOff;
        }

        protected override int GetLampsOnCount()
        {
            throw new NotImplementedException();
        }
    }
}
