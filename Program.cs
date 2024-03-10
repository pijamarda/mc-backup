using Microsoft.VisualBasic;
using System;
using System.IO.Compression;

namespace McBackup;

class Program
{
    static void Main(string[] args)
    {   
        string[] arguments = Environment.GetCommandLineArgs();
        string folderWorldArg = "";
        if (arguments.Length != 2)
        {
            Console.WriteLine("Please indicate the folder of the server where the world is");
            Console.WriteLine("You can use the following command: mc-backup /path/to/server");
        }
        else
        {
            folderWorldArg = Environment.GetCommandLineArgs()[1];
            Console.WriteLine("EXecuting backup of minecraft world");        
            Console.WriteLine($"{Environment.NewLine}Zipping, {folderWorldArg}");                
            CompressTest(folderWorldArg);
        } 
        
    }

    static void CompressTest(string startPath)
    {        
        string zipPath = @"output/backup/";
        string extractPath = @"output/backup";
        var currentDate = DateTime.Now.ToString("yyyyMMdd");
        string fileToSave = zipPath + startPath + currentDate + ".zip";

        if (File.Exists(fileToSave))
        {
            File.Delete(fileToSave);
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

        string inputFolder = startPath + @"/world/";

        ZipFile.CreateFromDirectory(inputFolder, fileToSave);
        //ZipFile.ExtractToDirectory(fileToSave, extractPath);
    }
}