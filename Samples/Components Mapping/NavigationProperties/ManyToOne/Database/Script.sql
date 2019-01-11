CREATE TABLE Countries (
  CountryID INTEGER PRIMARY KEY,
  CountryName VARCHAR(15) NOT NULL
);

CREATE TABLE Orders (
  OrderID INTEGER PRIMARY KEY,
  Customer VARCHAR(50) NOT NULL,
  ShipAddress VARCHAR(60),
  ShipCity VARCHAR(15),
  ShipCountryID INTEGER,
 CONSTRAINT FK_Orders_Countries FOREIGN KEY (ShipCountryID) REFERENCES Countries (CountryID)
);

CREATE TABLE Suppliers (
  SupplierID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(40) NOT NULL,
  Address VARCHAR(60),
  City VARCHAR(15),
  CountryID INTEGER,
 CONSTRAINT FK_Suppliers_Countries FOREIGN KEY (CountryID) REFERENCES Countries (CountryID)
);

INSERT INTO Countries VALUES (10,'USA');
INSERT INTO Countries VALUES (20,'China');
INSERT INTO Countries VALUES (30,'Germany');
INSERT INTO Countries VALUES (40,'United Kingdom');

INSERT INTO Orders VALUES (101,'NTP Co', '450 Seventh Avenue, Suite 2102', 'New York', 10);
INSERT INTO Orders VALUES (102,'UNKL Co', 'Schulstrasse 4', 'Hamburg', 30);

INSERT INTO Suppliers VALUES (1,'Supplier Co', 'Rm.2311 No.933 West Zhongshan Rd.', 'Shanghai', 20);
INSERT INTO Suppliers VALUES (2,'Contractor Co', '8 Pavilions Ruscombe Business Park', 'Berkshire', 40);