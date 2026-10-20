CREATE TABLE projects (
    id INTEGER GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(150) NOT NULL,
    description VARCHAR(1000),
    start_date DATE NOT NULL,
    deadline DATE,
    status VARCHAR(20) NOT NULL,

    CONSTRAINT pk_projects PRIMARY KEY (id),
    CONSTRAINT uq_projects_name UNIQUE (name),

    CONSTRAINT chk_projects_status
        CHECK (status IN ('PLANNED', 'ACTIVE', 'COMPLETED', 'CANCELLED')),

    CONSTRAINT chk_projects_deadline
        CHECK (deadline IS NULL OR deadline >= start_date)
);