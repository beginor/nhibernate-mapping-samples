CREATE TABLE Companies (
  CompanyID INTEGER NOT NULL,
  CompanyCode INTEGER NOT NULL,
  CompanyName VARCHAR(15) NOT NULL,
 CONSTRAINT PK_Companies PRIMARY KEY (CompanyID, CompanyCode)
);

CREATE TABLE Factories (
  FactoryID INTEGER NOT NULL,
  FactoryCode INTEGER NOT NULL,
  FactoryName VARCHAR(15) NOT NULL,
 CONSTRAINT PK_Companies PRIMARY KEY (FactoryID, FactoryCode)
);

CREATE TABLE CompanyFactories (
  CompanyID INTEGER NOT NULL,
  CompanyCode INTEGER NOT NULL,
  FactoryID INTEGER NOT NULL,
  FactoryCode INTEGER NOT NULL,
 CONSTRAINT PK_CompanyFactories PRIMARY KEY (CompanyID, CompanyCode, FactoryID, FactoryCode),
 CONSTRAINT FK_CompanyFactories_Companies FOREIGN KEY (CompanyID, CompanyCode) REFERENCES Companies (CompanyID, CompanyCode),
 CONSTRAINT FK_CompanyFactories_Factories FOREIGN KEY (FactoryID, FactoryCode) REFERENCES Factories (FactoryID, FactoryCode)
);

INSERT INTO Companies VALUES (1,74567,'Tailoring Co');
INSERT INTO Companies VALUES (2,49754,'Sewing Co');

INSERT INTO Factories VALUES (1,1111,'Chinese clothes manufacturing');
INSERT INTO Factories VALUES (2,2222,'Turkish clothes manufacturing');
INSERT INTO Factories VALUES (3,3333,'Italian clothes manufacturing');

INSERT INTO CompanyFactories VALUES (1,74567,2,2222);
INSERT INTO CompanyFactories VALUES (1,74567,3,3333);
INSERT INTO CompanyFactories VALUES (2,49754,1,1111);
INSERT INTO CompanyFactories VALUES (2,49754,2,2222);