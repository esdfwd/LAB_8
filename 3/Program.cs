using _3;
using System.Diagnostics;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const smartphoneFactory = new SmartphoneFactory();
const screen = smartphoneFactory.createScreen();
const processor = smartphoneFactory.createProcessor();
const camera = smartphoneFactory.createCamera();