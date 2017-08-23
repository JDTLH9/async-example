using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogAsync();

            Console.WriteLine("Enter something:");
            Console.WriteLine("Enter something else:");
            Console.WriteLine("Enter again!!!!:");
            Console.ReadLine();
        }

        private static void LogAsync()
        {
            Task.Run(() => CreateFile());
        }

        private static void CreateFile()
        {
            Thread.Sleep(3000);
            File.Create(@"C:\development\Learning\pwa\my-new-text.txt");
        }
    }
}