//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
				new Student("pinkman", "jessie", 22, "chemistry", "ww_220", 95, 96),
				new Teacher("white", "walter", 50, "chemistry", 25),
				new Graduate("Shrader", "Hank", 40, "Criminalistic", "OBN", 50, 70, "How to catch Haisenberg")
			};
		}
	}
}
