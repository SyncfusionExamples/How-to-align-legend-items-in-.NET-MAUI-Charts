using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendItemsLayout
{
    public class ChartDataModel
    {
        public ChartDataModel(string name, double value, double high, double low)
        {
            Name = name;
            Value = value;
            High = high;
            Low = low;
        }

        public ChartDataModel(string name, double value, double size)
        {
            Name = name;
            Value = value;
            Size = size;
        }


        public ChartDataModel(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public ChartDataModel(double name, double high, double low, double open, double close)
        {
            Data = name;
            High = high;
            Low = low;
            Value = open;
            Size = close;
        }

        public double Size { get; set; }

        public double High { get; set; }

        public double Value { get; set; }

        public double Data { get; set; }

        public double Low { get; set; }

        public string? Name { get; set; }

    }
}
