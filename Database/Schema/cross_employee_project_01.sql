CREATE TABLE cross_employee_projects (
    employee_id INTEGER NOT NULL,
    project_id INTEGER NOT NULL,

    CONSTRAINT pk_cross_employee_projects
        PRIMARY KEY (employee_id, project_id),

    CONSTRAINT fk_cross_employee_projects_to_employee
        FOREIGN KEY (employee_id)
        REFERENCES employees (id),

    CONSTRAINT fk_cross_employee_projects_to_project
        FOREIGN KEY (project_id)
        REFERENCES projects (id)
);