using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;
using Wpf_Playground.Models;

namespace Wpf_Playground.Pages
{
    public partial class EmployeesPage : Page
    {
        public EmployeesPage()
        {
            InitializeComponent();
            var projectAlpha = new Project
            {
                Id = 1,
                Name = "Project Alpha",
                Description = "Internal management system"
            };
            var projectBeta = new Project
            {
                Id = 2,
                Name = "Project Beta",
                Description = "Customer web platform"
            };
            var projectGamma = new Project
            {
                Id = 3,
                Name = "Project Gamma",
                Description = "Data analysis system"
            };

            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Rossi",
                    Email = "alice@example.com",
                    Department = "Engineering",
                    Projects = new List<Project>
                    {
                        projectAlpha,
                        projectGamma
                    }
                },

                new Employee
                {
                    Id = 2,
                    FirstName = "Marco",
                    LastName = "Bianchi",
                    Email = "marco@example.com",
                    Department = "Sales",
                    Projects = new List<Project>
                    {
                        projectBeta
                    }
                },

                new Employee
                {
                    Id = 3,
                    FirstName = "Luca",
                    LastName = "Romano",
                    Email = "luca@example.com",
                    Department = "Engineering",
                    Projects = new List<Project>
                    {
                        projectAlpha,
                        projectBeta
                    }
                }
            };

            EmployeesDataGrid.ItemsSource = employees;
        }

        private void EmployeesDataGrid_SelectionChanged(
            object sender,
            SelectionChangedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is Employee employee)
            {
                SelectedEmployeeId.Text = employee.Id.ToString();
                SelectedEmployeeFirstName.Text = employee.FirstName;
                SelectedEmployeeLastName.Text = employee.LastName;
                SelectedEmployeeEmail.Text = employee.Email;
                SelectedEmployeeDepartment.Text = employee.Department;

                SelectedEmployeeProjects.ItemsSource = employee.Projects;
            }
        }
    }
}
