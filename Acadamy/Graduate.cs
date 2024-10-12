using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy
{
	internal class Graduate:Student
	{
		public string DiplomaProject { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string diplomaProject
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			DiplomaProject = diplomaProject;
            Console.WriteLine($"GConstructor: {GetHashCode()}");
        }
		~Graduate() 
		{
            Console.WriteLine($"GDestructor: {GetHashCode()}");
        }
		public override void Print()
		{
			base.Print();
			Console.WriteLine($" {DiplomaProject}");
		}
		public override string ToString()
		{
			return base.ToString() + $" {DiplomaProject}";
		}
	}
}
