CREATE TABLE DepartmentPhone (
  DeptID INTEGER,
  PhoneID INTEGER,
  PhoneNumber VARCHAR(20),
  DeptName VARCHAR(14),
  Location VARCHAR(13),
 CONSTRAINT PK_DepartmentPhone PRIMARY KEY (DeptID, PhoneID)
);

INSERT INTO DepartmentPhone VALUES (1, 1, '(212) 714 - 9070', 'ACCOUNTING','NEW YORK');
INSERT INTO DepartmentPhone VALUES (1, 2, '(212) 714 - 9073', 'ACCOUNTING','NEW YORK');
INSERT INTO DepartmentPhone VALUES (2, 1, '(192) 711 - 7060', 'RESEARCH', 'DALLAS');
INSERT INTO DepartmentPhone VALUES (2, 2, '(192) 711 - 7061', 'RESEARCH','DALLAS');
INSERT INTO DepartmentPhone VALUES (3, 1, '(234) 743 - 4522', 'SALES','CHICAGO');