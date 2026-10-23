using System.Collections.Generic;
using System.Windows.Controls;
using Wpf_Playground.Models;

namespace Wpf_Playground.Pages
{
	public partial class ProjectsPage : Page
	{
		public ProjectsPage()
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


			var projects = new List<Project>
			{
				new Project
				{
					Id = 1,
					Name = "Project Alpha",
					Description = "Internal management system",
					Employees = new List<Employee>
					{
						alice,
						luca
					}
				},

				new Project
				{
					Id = 2,
					Name = "Project Beta",
					Description = "Customer web platform",
					Employees = new List<Employee>
					{
						marco,
						luca
					}
				},

				new Project
				{
					Id = 3,
					Name = "Project Gamma",
					Description = "Data analysis system",
					Employees = new List<Employee>
					{
						alice
					}
				}
			};

			ProjectsDataGrid.ItemsSource = projects;
		}


		private void ProjectsDataGrid_SelectionChanged(
			object sender,
			SelectionChangedEventArgs e)
		{
			if (ProjectsDataGrid.SelectedItem is Project project)
			{
				SelectedProjectId.Text = project.Id.ToString();
				SelectedProjectName.Text = project.Name;
				SelectedProjectDescription.Text = project.Description;

				SelectedProjectEmployees.ItemsSource = project.Employees;
			}
		}
	}
}