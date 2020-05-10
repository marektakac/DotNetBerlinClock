namespace BerlinClock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Rows;

    internal class Display
    {
        private readonly List<DisplayRow> displayRows;

        public Display(ITime time)
        {
            var displayRowFactory = new DisplayRowFactory(time);

            displayRows = new List<DisplayRow>
                          {
                              displayRowFactory.CreateNew(DisplayRowType.Seconds),
                              displayRowFactory.CreateNew(DisplayRowType.FiveHoursPerLamp),
                              displayRowFactory.CreateNew(DisplayRowType.OneHourPerLamp),
                              displayRowFactory.CreateNew(DisplayRowType.FiveMinutesPerLamp),
                              displayRowFactory.CreateNew(DisplayRowType.OneMinutePerLamp)
                          };
        }

        public string GetValue()
        {
            var rowValueList = displayRows.Select(displayRow => displayRow.GetRowValue());
            return string.Join(Environment.NewLine, rowValueList);
        }
    }
}
