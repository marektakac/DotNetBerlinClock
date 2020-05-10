namespace BerlinClock.Rows
{
    using System.Linq;

    internal abstract class DisplayRow
    {
        protected int LampsCount { get; }
        protected int NumberToDisplay { get; }
        protected static string ValueOff { get; } = "O";
        protected string ValueOn { get; }

        protected DisplayRow(int numberToDisplay, string valueOn, int lampsCount)
        {
            NumberToDisplay = numberToDisplay;
            ValueOn = valueOn;
            LampsCount = lampsCount;
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

        protected abstract int GetLampsOnCount();

        protected static string GetValueOfLamps(string lampValue, int countOfLamps)
        {
            return string.Concat(Enumerable.Repeat(lampValue, countOfLamps));
        }
    }
}
