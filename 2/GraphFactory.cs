using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class GraphFactory
    {
    }
}
class GraphFactory
{
    createChart(type)
    {
        switch (type)
        {
            case 'line':
                return new LineChart();
            case 'bar':
                return new BarChart();
            case 'pie':
                return new PieChart();
            default:
                throw new Error('Unsupported chart type');
        }
    }
}
