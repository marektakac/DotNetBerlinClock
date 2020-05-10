namespace BerlinClock.Rows
{
    using System;
    using System.Linq;

    internal abstract class DisplayRow
    {
        protected int CountOfLamps { get; }
        protected DisplayRow NextRow { get; private set; }
        protected ITime Time { get; }
        protected static string ValueOff { get; } = "O";
        protected string ValueOn { get; }

        protected DisplayRow(ITime time, string valueOn, int countOfLamps)
        {
            Time = time;
            ValueOn = valueOn;
            CountOfLamps = countOfLamps;
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

        protected static string GetValueOfLamps(string lampValue, int countOfLamps)
        {
            return string.Concat(Enumerable.Repeat(lampValue, countOfLamps));
        }

        protected string GetValueOfNextRow()
        {
            if (NextRow != null)
            {
                return string.Concat(Environment.NewLine, NextRow.GetValue());
            }

            return string.Empty;
        }
    }
}
