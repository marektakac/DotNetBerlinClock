namespace BerlinClock.Rows
{
    internal class OneMinutePerLampDisplayRow : OneUnitPerLampDisplayRow
    {
        public OneMinutePerLampDisplayRow(ITime time) : base(time.Minutes, "Y", 4)
        {
        }
    }
}
