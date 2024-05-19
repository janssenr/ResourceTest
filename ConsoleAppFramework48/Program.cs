using System;

namespace ConsoleAppFramework48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Resources.ResourceFile.TextFile;

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
