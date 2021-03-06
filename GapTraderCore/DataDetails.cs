﻿using System;

namespace GapTraderCore
{
    public struct DataDetails
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public double High { get; }
        public DateTime HighDate { get; }
        public double Low { get; }
        public DateTime LowDate { get; }
        public double AverageGapSize { get; }
        public TimeSpan OpenTime { get; }
        public TimeSpan CloseTime { get; }

        public DataDetails(DateTime startDate, DateTime endDate, double high, DateTime highDate, double low,
            DateTime lowDate, double averageGapSize, TimeSpan openTime, TimeSpan closeTime)
        {
            StartDate = startDate;
            EndDate = endDate;
            High = high;
            HighDate = highDate;
            Low = low;
            LowDate = lowDate;
            AverageGapSize = averageGapSize;
            OpenTime = openTime;
            CloseTime = closeTime;
        }
    }
}