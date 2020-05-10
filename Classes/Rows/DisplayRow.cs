namespace BerlinClock.Rows
{
    using System;

    internal abstract class DisplayRow
    {
        protected DisplayRow NextRow { get; private set; }
        protected ITime Time { get; }

        protected DisplayRow(ITime time)
        {
            Time = time;
        }

        public DisplayRow AddNextRow(DisplayRowType displayRowType)
        {
            switch (displayRowType)
            {
                case DisplayRowType.FiveHours:
                    NextRow = new FiveHoursDisplayRow(Time);
                    return NextRow;
                case DisplayRowType.OneHours:
                    NextRow = new OneHoursDisplayRow(Time);
                    return NextRow;
                case DisplayRowType.FiveMinutes:
                    NextRow = new FiveMinutesDisplayRow(Time);
                    return NextRow;
                case DisplayRowType.OneMinutes:
                    NextRow = new OneMinutesDisplayRow(Time);
                    return NextRow;
                case DisplayRowType.Seconds:
                    NextRow = new SecondsDisplayRow(Time);
                    return NextRow;
                default:
                    throw new ArgumentOutOfRangeException(nameof(displayRowType), displayRowType, null);
            }
        }

        public abstract string GetValue();
    }
}
