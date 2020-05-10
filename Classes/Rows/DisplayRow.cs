namespace BerlinClock.Rows
{
    using System.Linq;

    /// <summary>
    /// Base class for a representation of a display row. Use <see cref="DisplayRowFactory" /> to get the right instance.
    /// </summary>
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
            int lampsOnCount = GetLampsOnCount();
            string lampsOn = GetValueOfLamps(ValueOn, lampsOnCount);

            int lampsOffCount = LampsCount - lampsOnCount;
            string lampsOff = GetValueOfLamps(ValueOff, lampsOffCount);

            return string.Concat(lampsOn, lampsOff);
        }

        protected abstract int GetLampsOnCount();

        protected static string GetValueOfLamps(string lampValue, int countOfLamps)
        {
            return string.Concat(Enumerable.Repeat(lampValue, countOfLamps));
        }
    }
}
