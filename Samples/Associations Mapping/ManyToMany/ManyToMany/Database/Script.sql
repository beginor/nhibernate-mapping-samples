CREATE TABLE Companies (
  CompanyID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(15) NOT NULL
);

CREATE TABLE Factories (
  FactoryID INTEGER PRIMARY KEY,
  FactoryName VARCHAR(15) NOT NULL
);

CREATE TABLE CompanyFactories (
  CompanyID INTEGER NOT NULL,
  FactoryID INTEGER NOT NULL,
 CONSTRAINT PK_CompanyFactories PRIMARY KEY (CompanyID, FactoryID),
 CONSTRAINT FK_CompanyFactories_Companies FOREIGN KEY (CompanyID) REFERENCES Companies (CompanyID),
 CONSTRAINT FK_CompanyFactories_Factories FOREIGN KEY (FactoryID) REFERENCES Factories (FactoryID)
);

INSERT INTO Companies VALUES (1,'Tailoring Co');
INSERT INTO Companies VALUES (2,'Sewing Co');

INSERT INTO Factories VALUES (1,'Chinese clothes manufacturing');
INSERT INTO Factories VALUES (2,'Turkish clothes manufacturing');
INSERT INTO Factories VALUES (3,'Italian clothes manufacturing');

INSERT INTO CompanyFactories VALUES (1, 2);
INSERT INTO CompanyFactories VALUES (1, 3);
INSERT INTO CompanyFactories VALUES (2, 1);
INSERT INTO CompanyFactories VALUES (2, 2);