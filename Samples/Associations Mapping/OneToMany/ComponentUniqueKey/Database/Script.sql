CREATE TABLE Department (
  DepartmentId INTEGER PRIMARY KEY,
  Name VARCHAR(14),
  Phone VARCHAR(20),
 CONSTRAINT UK_DepartmentPhone UNIQUE (Name, Phone)
);

CREATE TABLE Employee (
  EmployeeId INTEGER PRIMARY KEY,
  Name VARCHAR(10),
  DepartmentName VARCHAR(14),
  DepartmentPhone VARCHAR(20),
 CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentName, DepartmentPhone) REFERENCES Department (Name, Phone)
);

INSERT INTO Department VALUES (10,'ACCOUNTING', '(212) 714 - 9070');
INSERT INTO Department VALUES (20,'RESEARCH', '(212) 714 - 9073');
INSERT INTO Department VALUES (30,'SALES', '(192) 711 - 7060');
INSERT INTO Department VALUES (40,'OPERATIONS','(234) 743 - 4522');

INSERT INTO Employee VALUES (7369,'SMITH','ACCOUNTING', '(212) 714 - 9070');
INSERT INTO Employee VALUES (7499,'ALLEN','RESEARCH','(212) 714 - 9073');
INSERT INTO Employee VALUES (7521,'WARD','RESEARCH','(212) 714 - 9073');
INSERT INTO Employee VALUES (7566,'JONES','SALES','(192) 711 - 7060');
