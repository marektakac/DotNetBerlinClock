namespace BerlinClock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Classes.Rows;
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
                              displayRowFactory.CreateNew(DisplayRowType.FiveHours),
                              displayRowFactory.CreateNew(DisplayRowType.OneHours),
                              displayRowFactory.CreateNew(DisplayRowType.FiveMinutes),
                              displayRowFactory.CreateNew(DisplayRowType.OneMinutes)
                          };
        }

        public string GetValue()
        {
            var rowValueList = displayRows.Select(displayRow => displayRow.GetRowValue());
            return string.Join(Environment.NewLine, rowValueList);
        }
    }
}
