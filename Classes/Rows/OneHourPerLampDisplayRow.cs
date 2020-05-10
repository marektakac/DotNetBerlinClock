namespace BerlinClock.Rows
{
    internal class OneHourPerLampDisplayRow : OneUnitPerLampDisplayRow
    {
        public OneHourPerLampDisplayRow(ITime time) : base(time.Hours, "R", 4)
        {
        }
    }
}
