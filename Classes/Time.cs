namespace BerlinClock
{
    using System;
    using System.Text.RegularExpressions;

    internal class Time : ITime
    {
        private const string TimePattern = "(?<hours>[0-1][0-9]|2[0-3]):(?<minutes>[0-5][0-9]):(?<seconds>[0-5][0-9])";
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        private Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public static ITime FromText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            var match = Regex.Match(text, TimePattern);
            if (!match.Success)
            {
                throw new ArgumentOutOfRangeException(nameof(text), text,
                    "Expected a time value in format 'HH:MM:SS'.");
            }

            int hours = int.Parse(match.Groups["hours"].Value);
            int minutes = int.Parse(match.Groups["minutes"].Value);
            int seconds = int.Parse(match.Groups["seconds"].Value);

            return new Time(hours, minutes, seconds);
        }
    }
}
