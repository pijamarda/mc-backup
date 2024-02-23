using Microsoft.VisualBasic;
using System;
using System.IO.Compression;

namespace McBackup;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}");
        Console.WriteLine($"{Environment.NewLine}Press any key to exit.");
        //Console.ReadKey(true);
        CompressTest();
    }

    static void CompressTest()
    {
        string startPath = @"output/start";
        string zipPath = @"output/result.zip";
        string extractPath = @"output/extract";

        if (File.Exists(zipPath))
        {
            File.Delete(zipPath);
        }

        try
        {
            var files = Directory.EnumerateFiles(extractPath);

            foreach (string currentFile in files)
            {
                File.Delete(currentFile);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        ZipFile.CreateFromDirectory(startPath, zipPath);
        ZipFile.ExtractToDirectory(zipPath, extractPath);
    }
}