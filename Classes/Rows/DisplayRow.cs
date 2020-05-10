namespace BerlinClock.Rows
{
    using System;
    using System.Linq;

    internal abstract class DisplayRow
    {
        protected int LampsCount { get; }
        protected int NumberToDisplay { get; }
        protected static string ValueOff { get; } = "O";
        protected string ValueOn { get; }
        private DisplayRow NextRow { get; set; }

        protected DisplayRow(int numberToDisplay, string valueOn, int lampsCount)
        {
            NumberToDisplay = numberToDisplay;
            ValueOn = valueOn;
            LampsCount = lampsCount;
        }

        public DisplayRow AddNextRow(DisplayRowType displayRowType, ITime time)
        {
            switch (displayRowType)
            {
                case DisplayRowType.FiveHours:
                    NextRow = new FiveHoursDisplayRow(time);
                    return NextRow;
                case DisplayRowType.OneHours:
                    NextRow = new OneHoursDisplayRow(time);
                    return NextRow;
                case DisplayRowType.FiveMinutes:
                    NextRow = new FiveMinutesDisplayRow(time);
                    return NextRow;
                case DisplayRowType.OneMinutes:
                    NextRow = new OneMinutesDisplayRow(time);
                    return NextRow;
                case DisplayRowType.Seconds:
                    NextRow = new SecondsDisplayRow(time);
                    return NextRow;
                default:
                    throw new ArgumentOutOfRangeException(nameof(displayRowType), displayRowType, null);
            }
        }

        public virtual string GetRowValue()
        {
            int countOfLampsOn = GetLampsOnCount();
            string lampsOn = GetValueOfLamps(ValueOn, countOfLampsOn);

            int countOfLampsOff = LampsCount - countOfLampsOn;
            string lampsOff = GetValueOfLamps(ValueOff, countOfLampsOff);

            string rowValue = string.Concat(lampsOn, lampsOff);
            return rowValue;
        }

        protected static string GetValueOfLamps(string lampValue, int countOfLamps)
        {
            return string.Concat(Enumerable.Repeat(lampValue, countOfLamps));
        }

        protected string GetValueOfNextRow()
        {
            if (NextRow != null)
            {
                return string.Concat(Environment.NewLine, NextRow.GetRowValue());
            }

            return string.Empty;
        }

        protected abstract int GetLampsOnCount();
    }
}
