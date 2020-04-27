using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private DateTime startDate;
        private DateTime endDate;

        public DateModifier(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public DateTime StartDate
        {
            get => this.startDate;
            set => this.startDate = value;
        }

        public DateTime EndDate
        {
            get => this.endDate;
            set => this.endDate = value;
        }

        public double DateDifferenceInDays()
        {
            var difference = (StartDate - EndDate).TotalDays;
            return Math.Abs(difference);

        }
    }
}
