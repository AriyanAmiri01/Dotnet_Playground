using System.Collections.Generic;
using System.Windows.Controls;
using Wpf_Playground.Models;

namespace Wpf_Playground.Pages
{
	public partial class DepartmentsPage : Page
	{
		public DepartmentsPage()
		{
			InitializeComponent();

			var alice = new Employee
			{
				Id = 1,
				FirstName = "Alice",
				LastName = "Rossi",
				Email = "alice@example.com",
				Department = "Engineering"
			};

			var marco = new Employee
			{
				Id = 2,
				FirstName = "Marco",
				LastName = "Bianchi",
				Email = "marco@example.com",
				Department = "Sales"
			};

			var luca = new Employee
			{
				Id = 3,
				FirstName = "Luca",
				LastName = "Romano",
				Email = "luca@example.com",
				Department = "Engineering"
			};


			var departments = new List<Department>
			{
				new Department
				{
					Id = 1,
					Name = "Engineering",
					Description = "Software and technical development",
					Employees = new List<Employee>
					{
						alice,
						luca
					}
				},

				new Department
				{
					Id = 2,
					Name = "Sales",
					Description = "Sales and customer acquisition",
					Employees = new List<Employee>
					{
						marco
					}
				}
			};

			DepartmentsDataGrid.ItemsSource = departments;
		}

		private void DepartmentsDataGrid_SelectionChanged(
			object sender,
			SelectionChangedEventArgs e)
		{
			if (DepartmentsDataGrid.SelectedItem is Department department)
			{
				SelectedDepartmentId.Text = department.Id.ToString();
				SelectedDepartmentName.Text = department.Name;
				SelectedDepartmentDescription.Text = department.Description;

				SelectedDepartmentEmployees.ItemsSource = department.Employees;
			}
		}
	}
}