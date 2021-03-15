using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.ChartJs.Model
{
    public class Chart
    {
        public ChartType Type { get; set; }
        public string ChartJsType
        {
            get
            {
                switch (Type)
                {
                    case ChartType.Vertical:
                        return "bar";
                    case ChartType.Horizontal:
                        return "horizontalBar";
                    case ChartType.Line:
                        return "line";
                    default:
                        return "bar";
                }
            }
        }
        public string Id { get; set; }
        public List<string> Labels { get; set; }
        public List<ChartDataset> Datasets { get; set; }
        public bool IsStacked { get; set; }
    }
}
