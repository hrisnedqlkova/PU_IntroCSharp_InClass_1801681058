using System;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;

			Console.WriteLine("");
			// Example #2
			// Read each line of the file into a string array. Each element
			// of the array is one line of the file.
			string[] lines = System.IO.File.ReadAllLines(@"C:\Users\fmi\Desktop\InClass\PU_IntroCSharp_InClass_1801681058\PUInClassW3\CandyShop\files\students.txt");

			// Display the file contents by using a foreach loop.
			System.Console.WriteLine("Contents of WriteLines2.txt = ");
			int tStudents = 0;
			foreach (string line in lines)
			{
				string[] elements = line.Split(' ');
				string firstName = elements[1];
				string name = $"{firstName} {elements[3]}";
				// Use a tab to indent each line of the file.
				//Console.WriteLine("\t" + line);
				int sum = 0;
				for (int i = 0; i < firstName.Length; i++)
				{
					sum +=(int)firstName[i];
				}

				if (sum>7000)
				{
				  tStudents += 1;
                  Console.WriteLine($"Candy for {name} => {firstName.Length}");
					
				}

				


				Console.WriteLine($"TOTAL LINES{lines}");
				Console.WriteLine($"Total students:{tStudents}");

				Console.ReadKey();


				

			}

		}
	}
}
