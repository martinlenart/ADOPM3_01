using System;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ADOPM3_01_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string startPath = Path.Combine(documentPath, "AOOP2", "Examples");
            string zipFile = Path.Combine(documentPath, "AOOP2", "Examples.zip");
            string extractPath = Path.Combine(documentPath, "AOOP2", "Extract");

            if (File.Exists(zipFile)) File.Delete(zipFile);
            ZipFile.CreateFromDirectory(startPath, zipFile);
            Console.WriteLine($"Zip Created: {zipFile}");

            if (Directory.Exists(extractPath)) Directory.Delete(extractPath, true);
            ZipFile.ExtractToDirectory(zipFile, extractPath);
            Console.WriteLine($"Zip Extracted: {extractPath}");

        }

        //Exercises:
        //1.    Use ZipArchive to iterate over "Examples.zip" and printout content. 
        //2.    Use ZipCreate to add a file to "Examples.zip", Use ZipArchive to confirm that it is included in the zip file.
    }
}
