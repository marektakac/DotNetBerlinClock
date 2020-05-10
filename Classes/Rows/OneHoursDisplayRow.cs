namespace BerlinClock.Rows
{
    internal class OneHoursDisplayRow : OneUnitPerLampDisplayRow
    {
        public OneHoursDisplayRow(ITime time) : base(time.Hours, "R", 4)
        {
        }
    }
}
