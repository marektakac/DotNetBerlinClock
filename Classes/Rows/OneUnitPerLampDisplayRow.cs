namespace BerlinClock.Rows
{
    internal abstract class OneUnitPerLampDisplayRow : DisplayRow
    {
        protected OneUnitPerLampDisplayRow(int numberToDisplay, string valueOn, int lampsCount) : base(numberToDisplay,
            valueOn, lampsCount)
        {
        }

        protected override int GetLampsOnCount()
        {
            return NumberToDisplay % 5;
        }
    }
}
