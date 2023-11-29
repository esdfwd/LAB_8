using _4;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const prototype = new CSVData();
const clonedData = prototype.clone();
const adapter = new DataAdapter();
const jsonData = adapter.convertToJSON(clonedData);
// Вивід результату або збереження в файл