using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RangeColumnChartDemo
{
    public class ViewModel
    {
        List<Model> temperatureCollection;
        public List<Model> TemperatureCollection
        {
            get
            {
                return temperatureCollection;
            }
            set
            {
                temperatureCollection = value;
            }
        }

        public ViewModel()
        {
            TemperatureCollection = new List<Model>(ReadCSV());
        }

        public IEnumerable<Model> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("RangeColumnChartDemo.Resources.Raw.Rome monthly data.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new Model(data[0], Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[4]), Convert.ToDouble(data[5]));
            });
        }
    }
}
