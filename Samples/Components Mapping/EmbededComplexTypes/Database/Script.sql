CREATE TABLE Orders (
  OrderID INTEGER PRIMARY KEY,
  CustomerID INTEGER NOT NULL,
  OrderDate DATETIME NULL,
  RequiredDate DATETIME NULL,
  ShippedDate DATETIME NULL,
  ShipVia INTEGER NULL,
  Freight INTEGER DEFAULT 0,
  ShipName VARCHAR(40) NULL,
  ShipAddress VARCHAR(60) NULL,
  ShipCity VARCHAR(15) NULL,
  ShipRegion VARCHAR(15) NULL,
  ShipPostalCode VARCHAR(10) NULL,
  ShipCountry VARCHAR(15) NULL
);

CREATE TABLE Customers (
  CustomerID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(40) NOT NULL,
  ContactName VARCHAR(30) NULL,
  ContactTitle VARCHAR(30) NULL,
  Address VARCHAR(60) NULL,
  City VARCHAR(15) NULL,
  Region VARCHAR(15) NULL,
  PostalCode VARCHAR(10) NULL,
  Country VARCHAR(15) NULL,
  Phone VARCHAR(24)  NULL,
  Fax VARCHAR(24) NULL
);

INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (1, 'Alfreds Futterkiste', 'Maria Anders', 'Sales Representative', 'Obere Str. 57', 'Berli', 'SP', '12209', 'Germany', '0300-074321', '030-0076545');
INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (2, 'Ana Trujillo Emparedados y helados', 'Ana Trujillo', 'Owner', 'Avda. de la Constitucion 2222', 'Mexico D.F.', NULL, '05021', 'Mexico', '(5) 555-4729', '(5) 555-3745');
INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (3, 'Antonio Moreno Taqueria', 'Antonio Moreno', 'Owner', 'Mataderos  2312', 'Mexico D.F.', NULL, '05023', 'Mexico', '(5) 555-3932', NULL);
INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (4, 'Around the Hor', 'Thomas Hardy', 'Sales Representative', '120 Hanover Sq.', 'Londo', NULL, 'WA1 1DP', 'UK', '(171) 555-7788', '(171) 555-6750');

INSERT INTO Orders(OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (1, 1, '1996-07-04 00:00:00.000', '1996-08-01 00:00:00.000', '1996-07-16 00:00:00.000', 3, 32.38, 'Vins et alcools Chevalier', '59 rue de l''Abbaye', 'Reims', NULL, '51100', 'France');
INSERT INTO Orders(OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (2, 2, '1996-07-05 00:00:00.000', '1996-08-16 00:00:00.000', '1996-07-10 00:00:00.000', 1, 11.61, 'Toms Spezialitate', 'Luisenstr. 48', 'Munster', NULL, '44087', 'Germany');
INSERT INTO Orders(OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (3, 3, '1996-07-08 00:00:00.000', '1996-08-05 00:00:00.000', '1996-07-12 00:00:00.000', 2, 65.83, 'Hanari Carnes', 'Rua do Paco, 67', 'Rio de Janeiro', 'RJ', '05454-876', 'Brazil');
INSERT INTO Orders(OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (4, 4, '1996-07-08 00:00:00.000', '1996-08-05 00:00:00.000', '1996-07-15 00:00:00.000', 1, 41.34, 'Victuailles en stock', '2, rue du Commerce', 'Lyo', NULL, '69004', 'France');