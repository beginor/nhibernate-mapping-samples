CREATE TABLE Companies (
  CompanyID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(15) NOT NULL,
 CONSTRAINT UK_Companies UNIQUE (CompanyName)
);

CREATE TABLE Factories (
  FactoryID INTEGER PRIMARY KEY,
  FactoryName VARCHAR(15) NOT NULL,
 CONSTRAINT UK_Factories UNIQUE (FactoryName)
);

CREATE TABLE CompanyFactories (
  CompanyName VARCHAR(15) NOT NULL,
  FactoryName VARCHAR(15) NOT NULL,
 CONSTRAINT PK_CompanyFactories PRIMARY KEY (CompanyName, FactoryName),
 CONSTRAINT FK_CompanyFactories_Companies FOREIGN KEY (CompanyName) REFERENCES Companies (CompanyName),
 CONSTRAINT FK_CompanyFactories_Factories FOREIGN KEY (FactoryName) REFERENCES Factories (FactoryName)
);

INSERT INTO Companies VALUES (1,'Tailoring Co');
INSERT INTO Companies VALUES (2,'Sewing Co');

INSERT INTO Factories VALUES (1,'Chinese clothes manufacturing');
INSERT INTO Factories VALUES (2,'Turkish clothes manufacturing');
INSERT INTO Factories VALUES (3,'Italian clothes manufacturing');

INSERT INTO CompanyFactories VALUES ('Tailoring Co', 'Turkish clothes manufacturing');
INSERT INTO CompanyFactories VALUES ('Tailoring Co', 'Italian clothes manufacturing');
INSERT INTO CompanyFactories VALUES ('Sewing Co', 'Chinese clothes manufacturing');
INSERT INTO CompanyFactories VALUES ('Sewing Co', 'Turkish clothes manufacturing');