using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Moduls
{
	public class Group
	{
		static Group[] Groups = new Group[0];
	   public static int GroupCount;
	   public int GroupId;
		public string GroupName;
		Student[] Students = new Student[0];

		public Group(string groupname)
		{
			GroupId = ++GroupCount;
			GroupName = groupname;
			
		}
		public string GetGroupInfo() 
		{
			Console.WriteLine($"{GroupName}, {GroupId}");
		}

		





	}
    
	


}
