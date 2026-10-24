
-- Selects all the employees
SELECT *
FROM employees;


-- Selecta all the employees with their department info
SELECT *
FROM employees
JOIN departments
	on employees.department_id = departments.id;

-- Selects employees short details connected with a particular department
SELECT
    employees.first_name,
    employees.last_name,
    employees.job_title,
    departments.name AS department_name
FROM employees
JOIN departments
    ON employees.department_id = departments.id
WHERE departments.id = @department_id;




CREATE FUNCTION Read_Employee_WithDepartmentNum(a INTEGER)
RETURNS TABLE
(
    first_name VARCHAR,
    last_name VARCHAR,
    job_title VARCHAR,
    department_name VARCHAR
)
AS $$
    SELECT
        employees.first_name,
        employees.last_name,
        employees.job_title,
        departments.name AS department_name
    FROM employees
    JOIN departments
        ON employees.department_id = departments.id
    WHERE departments.id = a;
$$
LANGUAGE SQL;
