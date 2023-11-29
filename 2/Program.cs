using _2;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const factory = new GraphFactory();
const chartType = 'line'; // Користувач вводить тип графіка
const chart = factory.createChart(chartType);
chart.draw(); // Вивести графік