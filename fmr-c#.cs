using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CodeSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Outer infinite loop
            {
                Console.WriteLine("code or txt");
                Thread.Sleep(200); // 0.2 seconds

                var fullCodeLines = new List<string>();

                while (true) // Inner loop for collecting code lines
                {
                    Thread.Sleep(500); // 0.5 seconds
                    Console.Write(" -  ");
                    string inputLine = Console.ReadLine();

                    if (inputLine == "save")
                    {
                        break;
                    }

                    fullCodeLines.Add(inputLine);
                }

                Thread.Sleep(200); // 0.2 seconds
                Console.Write("file name -  ");
                string fileName = Console.ReadLine();

                // Append the collected lines to the specified file
                using (var writer = new StreamWriter(fileName, append: true))
                {
                    foreach (var line in fullCodeLines)
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine("file successfully saved!");
            }
        }
    }
}
