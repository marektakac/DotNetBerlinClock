namespace BerlinClock.Rows
{
    internal class OneMinutesDisplayRow : OneUnitPerLampDisplayRow
    {
        public OneMinutesDisplayRow(ITime time) : base(time.Minutes, "Y", 4)
        {
        }
    }
}
