


using System.Collections.Generic;
namespace Wpf_Playground.Models
{
    public class Employee
    {
		// Variables
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Department { get; set; } = "";
        public List<Project> Projects { get; set; } = new();

		// Properties
		public string FullName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}
	}
}