SELECT 
	employees.first_name, 
	employees.last_name, 
	projects.name AS project_name
FROM cross_employee_projects
JOIN employees
    ON cross_employee_projects.employee_id = employees.id
JOIN projects
    ON cross_employee_projects.project_id = projects.id;