CREATE TABLE employees (
    id INTEGER GENERATED ALWAYS AS IDENTITY,
    CONSTRAINT cons_id PRIMARY KEY (id),

    email VARCHAR(255)
        CONSTRAINT cons_email NOT NULL UNIQUE,

    department_id INTEGER
        CONSTRAINT cons_department_id_not_null NOT NULL,
		
    CONSTRAINT cons_department_id
        FOREIGN KEY (department_id)
        REFERENCES departments (id),

    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    job_title VARCHAR(100),
    hire_date DATE NOT NULL
);