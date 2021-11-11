using System;
using System.IO;
using System.Linq;

namespace ADOPM3_01_10
{
    class Program
    {
        static void Main(string[] args)
        {
			using (FileStream fs = File.Create(fname("Example4_10.txt")))
			using (TextWriter writer = new StreamWriter(fs))
			{
				var nl = string.Join("", writer.NewLine.Select(c => $"0x{(int)c:X2} "));
				Console.WriteLine($"Newline is {nl} ");

				writer.WriteLine("Line1");
				writer.WriteLine("Line2");
			}

			using (FileStream fs = File.OpenRead(fname("Example4_10.txt")))
			using (TextReader reader = new StreamReader(fs))
			{
				Console.WriteLine(reader.ReadLine());       // Line1
				Console.WriteLine(reader.ReadLine());       // Line2
			}

			static string fname(string name)
			{
				var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				documentPath = Path.Combine(documentPath, "AOOP2", "Examples");
				if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
				return Path.Combine(documentPath, name);
			}
		}
	}
}
