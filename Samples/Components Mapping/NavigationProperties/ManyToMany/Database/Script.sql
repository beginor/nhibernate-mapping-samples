CREATE TABLE Companies (
  CompanyID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(15) NOT NULL
);

CREATE TABLE Factories (
  FactoryID INTEGER PRIMARY KEY,
  FactoryName VARCHAR(15) NOT NULL,
  FactoryAddress VARCHAR(200),
  WorkersCount INTEGER
);

CREATE TABLE Shops (
  ShopID INTEGER PRIMARY KEY,
  ShopName VARCHAR(15) NOT NULL,
  ShopAddress VARCHAR(60)
);

CREATE TABLE CompanyFactories (
  CompanyID INTEGER NOT NULL,
  FactoryID INTEGER NOT NULL,
 PRIMARY KEY (CompanyID, FactoryID),
 FOREIGN KEY (CompanyID) REFERENCES Companies (CompanyID),
 FOREIGN KEY (FactoryID) REFERENCES Factories (FactoryID)
);

CREATE TABLE CompanyShops (
  CompanyID INTEGER NOT NULL,
  ShopID INTEGER NOT NULL,
 PRIMARY KEY (CompanyID, ShopID),
 FOREIGN KEY (CompanyID) REFERENCES Companies (CompanyID),
 FOREIGN KEY (ShopID) REFERENCES Shops (ShopID)
);

INSERT INTO Companies VALUES (1,'Tailoring Co');
INSERT INTO Companies VALUES (2,'Sewing Co');

INSERT INTO Factories VALUES (1,'Chinese clothes manufacturing','Rm.2311 No.933 West Zhongshan Rd.,Shanghai,China' ,400);
INSERT INTO Factories VALUES (2,'American clothes manufacturing', '450 Seventh Avenue, Suite 2102,New York,USA',240);
INSERT INTO Factories VALUES (3,'German clothes manufacturing', 'Schulstrasse 4,Hamburg,Germany',190);

INSERT INTO Shops VALUES (1,'Chinese Clothing Store','Rm.2311 No.50 West Zhongshan Rd.,Shanghai,China');
INSERT INTO Shops VALUES (2,'American Clothing Store','450 Seventh Avenue, Suite 1760,New York,USA');
INSERT INTO Shops VALUES (3,'German Clothing Store','Schulstrasse 20,Hamburg,Germany');

INSERT INTO CompanyFactories VALUES (1, 2);
INSERT INTO CompanyFactories VALUES (1, 3);
INSERT INTO CompanyFactories VALUES (2, 1);
INSERT INTO CompanyFactories VALUES (2, 2);

INSERT INTO CompanyShops VALUES (1, 2);
INSERT INTO CompanyShops VALUES (1, 3);
INSERT INTO CompanyShops VALUES (2, 1);
INSERT INTO CompanyShops VALUES (2, 2);