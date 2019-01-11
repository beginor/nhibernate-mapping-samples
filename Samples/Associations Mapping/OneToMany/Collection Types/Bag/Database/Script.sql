CREATE TABLE Department (
  DepartmentId INTEGER PRIMARY KEY,
  Name VARCHAR(14)
);

CREATE TABLE Employee (
  EmployeeId INTEGER PRIMARY KEY,
  Name VARCHAR(10),
  DepartmentId INTEGER NOT NULL,
 CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentId) REFERENCES Department (DepartmentId)
);

INSERT INTO Department VALUES (10,'ACCOUNTING');
INSERT INTO Department VALUES (20,'RESEARCH');
INSERT INTO Department VALUES (30,'SALES');
INSERT INTO Department VALUES (40,'OPERATIONS');

INSERT INTO Employee VALUES (7369,'SMITH',10);
INSERT INTO Employee VALUES (7499,'ALLEN',30);
INSERT INTO Employee VALUES (7521,'WARD',30);
INSERT INTO Employee VALUES (7566,'JONES',20);
