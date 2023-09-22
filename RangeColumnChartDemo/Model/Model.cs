using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeColumnChartDemo
{
    public class Model
    {
        public Model(string month, double high2021, double low2021, double high2022, double low2022)
        {
            Month = month;
            High2021 = high2021;
            Low2021 = low2021;
            High2022 = high2022;
            Low2022 = low2022;
        }

        public string Month { get; set; }
        public double High2021 { get; set; }
        public double Low2021 { get; set; }
        public double High2022 { get; set; }
        public double Low2022 { get; set; }
    }
}
