CREATE TABLE DepartmentPhone (
  DepartmentId INTEGER,
  PhoneID INTEGER,
  PhoneNumber VARCHAR(20),
  Name VARCHAR(14),
 CONSTRAINT PK_DepartmentPhone PRIMARY KEY (DepartmentId, PhoneID)
);

CREATE TABLE Employee (
  EmployeeId INTEGER PRIMARY KEY,
  Name VARCHAR(10),
  DepartmentId INTEGER,
  DepartmentPhoneId INTEGER,
 CONSTRAINT FK_Employees_DepartmentPhone FOREIGN KEY (DepartmentId, DepartmentPhoneID) REFERENCES DepartmentPhone (DepartmentId, PhoneID)
);

INSERT INTO DepartmentPhone VALUES (1, 1, '(212) 714 - 9070', 'ACCOUNTING');
INSERT INTO DepartmentPhone VALUES (1, 2, '(212) 714 - 9073', 'ACCOUNTING');
INSERT INTO DepartmentPhone VALUES (2, 1, '(192) 711 - 7060', 'RESEARCH');
INSERT INTO DepartmentPhone VALUES (2, 2, '(192) 711 - 7061', 'RESEARCH');
INSERT INTO DepartmentPhone VALUES (3, 1, '(234) 743 - 4522', 'SALES');

INSERT INTO Employee VALUES (7369,'SMITH', 1, 1);
INSERT INTO Employee VALUES (7499,'ALLEN', 1, 1);
INSERT INTO Employee VALUES (7521,'WARD', 2, 2);
INSERT INTO Employee VALUES (7566,'JONES', 3, 1);