using System;
using System.IO;
using System.Linq;

namespace ADOPM3_01_10
{
    class Program
    {
        static void Main(string[] args)
        {
			string filename = fname("Example4_10.txt");

			using (FileStream fs = File.Create(filename))
			using (TextWriter writer = new StreamWriter(fs))
			{
				writer.WriteLine(filename);
				writer.WriteLine("Hello World");
				writer.WriteLine(int.MaxValue.ToString());
				writer.WriteLine(double.MaxValue.ToString());
			}


			using (FileStream fs = File.OpenRead(fname("Example4_10.txt")))
			using (TextReader reader = new StreamReader(fs))
			{
				Console.WriteLine(reader.ReadLine());       
				Console.WriteLine(reader.ReadLine());       
				Console.WriteLine(reader.ReadLine());       
				Console.WriteLine(reader.ReadLine());       
			}

			static string fname(string name)
			{
				var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				documentPath = Path.Combine(documentPath, "ADOP", "Examples");
				if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
				return Path.Combine(documentPath, name);
			}
		}
	}
}

