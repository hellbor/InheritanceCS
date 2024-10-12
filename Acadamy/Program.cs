//#define INHERITANCE_CHECK
//#define HOMEWORK
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Acadamy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher);

			Graduate graduate = new Graduate("Shrader", "Hank", 40, "Criminalistic", "OBN", 50, 70, "How to catch Haisenberg");
			graduate.Print();
			Console.WriteLine(graduate);
#endif
			Human[] group = new Human[]
			{
				new Human("Montana", "Antonio", 25),
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Shrader", "Hank", 40, "Criminalistic", "DEA", 70, 50, "How to catch Haisenberg"),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 97, 98),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
			};
			Streamer.Print(group);
			Streamer.Save(group, "group.txt");
#if HOMEWORK
			StreamWriter sw = new StreamWriter("File.txt");
			Console.WriteLine(group.ToString());

			foreach (Human i in group)
			{
				sw.WriteLine(i);
			}
			sw.Close();
			Process.Start("notepad", "File.txt");

			StreamReader sr = new StreamReader("File.txt");
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(buffer);
			}
			sr.Close(); 
#endif
		}
	}
}
