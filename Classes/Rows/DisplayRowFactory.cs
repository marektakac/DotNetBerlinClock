namespace BerlinClock.Classes.Rows
{
    using System;
    using BerlinClock.Rows;

    internal class DisplayRowFactory
    {
        private readonly ITime time;

        public DisplayRowFactory(ITime time)
        {
            this.time = time;
        }

        public DisplayRow CreateNew(DisplayRowType displayRowType)
        {
            switch (displayRowType)
            {
                case DisplayRowType.FiveHours:
                    return new FiveHoursDisplayRow(time);
                case DisplayRowType.OneHours:
                    return new OneHoursDisplayRow(time);
                case DisplayRowType.FiveMinutes:
                    return new FiveMinutesDisplayRow(time);
                case DisplayRowType.OneMinutes:
                    return new OneMinutesDisplayRow(time);
                case DisplayRowType.Seconds:
                    return new SecondsDisplayRow(time);
                default:
                    throw new ArgumentOutOfRangeException(nameof(displayRowType), displayRowType, null);
            }
        }
    }
}
