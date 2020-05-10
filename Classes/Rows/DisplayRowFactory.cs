namespace BerlinClock.Rows
{
    using System;

    internal class DisplayRowFactory
    {
        private readonly ITime time;

        public DisplayRowFactory(ITime time)
        {
            this.time = time;
        }

        public DisplayRow CreateNew(DisplayRowType displayRowType)
        {
            switch (displayRowType)
            {
                case DisplayRowType.FiveHoursPerLamp:
                    return new FiveHoursPerLampDisplayRow(time);
                case DisplayRowType.OneHourPerLamp:
                    return new OneHourPerLampDisplayRow(time);
                case DisplayRowType.FiveMinutesPerLamp:
                    return new FiveMinutesPerLampDisplayRow(time);
                case DisplayRowType.OneMinutePerLamp:
                    return new OneMinutePerLampDisplayRow(time);
                case DisplayRowType.Seconds:
                    return new SecondsDisplayRow(time);
                default:
                    throw new ArgumentOutOfRangeException(nameof(displayRowType), displayRowType, null);
            }
        }
    }
}
