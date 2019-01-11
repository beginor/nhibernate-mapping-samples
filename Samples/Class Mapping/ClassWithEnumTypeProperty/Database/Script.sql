CREATE TABLE Employee (
  EmployeeID INTEGER PRIMARY KEY,
  EmployeeType INTEGER NOT NULL,
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL
);

-- EmployeeType:
-- 1 - Manager
-- 2 - Clerk
-- 3 - Courier
INSERT INTO Employee VALUES (10,1,'Martin','Schaich');
INSERT INTO Employee VALUES (20,2,'Katrin','Jonsdottir');
INSERT INTO Employee VALUES (30,2,'Mary','Godwin');
INSERT INTO Employee VALUES (40,3,'John','Menson');