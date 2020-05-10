namespace BerlinClock.Rows
{
    internal abstract class OneUnitPerLampDisplayRow : DisplayRow
    {
        protected OneUnitPerLampDisplayRow(int numberToDisplay, string valueOn, int lampsCount) : base(numberToDisplay, valueOn, lampsCount)
        {
        }

        public override string GetRowValue()
        {
            return string.Concat(base.GetRowValue(), GetValueOfNextRow());
        }

        protected override int GetLampsOnCount()
        {
            return NumberToDisplay % 5;
        }
    }
}
