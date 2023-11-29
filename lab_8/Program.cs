using System;

namespace lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const configManager = ConfigurationManager.getInstance();
configManager.setConfig('logging', 'enabled');
console.log(configManager.getConfig('logging')); // 'enabled'