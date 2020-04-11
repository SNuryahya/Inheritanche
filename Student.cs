using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInInheritance
{
	public class Student : Person
	{
		public string StudentId { get; set; }
		public string Email { get; set; }
		public Student(string Name, int Age, string mStudentId, string mEmail) : base(Name, Age)
		{
			mName = Name;
			mAge = Age;
			mStudentId = StudentId;
			mEmail = Email;
		}
	}
}

  
