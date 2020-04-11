using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInInheritance
{
	public class Teacher : Person
	{
		public string TeacherId;
		public string Subject;
		public Teacher(string Name, int Age, string mTid, string mSubject) : base(Name, Age)
		{
			mName = Name;
			mAge = Age;
			mTid = TeacherId;
			mSubject = Subject;
		}
	}
}
