using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Moduls
{
	public class Student
	{
		private static int _count = 0;
		public int _id
		{
			get { return _count; }
			set { _count = value; }
				}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string surname 
		{
			get { return surname; }
			set { surname = value; }
		}


		public Student( string name, string surname)
		{
		

		}

		public static void Capitalize( string text)
		{
			text= text.Substring(0,1).ToLower() + text.Substring(1).ToLower();
		}
		public void GetInfo()
		{
			Console.WriteLine($"{name} , {surname}");
		}
	}
}
