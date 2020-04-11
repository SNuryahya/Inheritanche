using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LatihanInInheritance
{
	public class Program
	{
		public Program()
		{

		}

		static void Main(string[] args)
		{
			Person person = new Person("Sulis", 20);
			person.GetNameAndAge();

			Teacher teacher = new Teacher("Ryan", 35, "190302", "Algorithm");
			teacher.GetNameAndAge();

			Student student = new Student("sulistiya", 18, "19112619", "sulistiya.n@students.amikom.ac.id");
			student.GetNameAndAge();

			Console.ReadKey();
		}
	}
}
