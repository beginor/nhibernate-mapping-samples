CREATE TABLE Companies (
  CompanyID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(15) NOT NULL
);

CREATE TABLE Factories (
  FactoryID INTEGER PRIMARY KEY,
  FactoryName VARCHAR(15) NOT NULL
);

CREATE TABLE CompanyFactoriesContractors (
  CompanyID INTEGER NOT NULL,
  FactoryID INTEGER NOT NULL,
  ContractorID INTEGER NOT NULL,
 CONSTRAINT PK_CompanyFactoriesContractors PRIMARY KEY (CompanyID, FactoryID, ContractorID),
 CONSTRAINT FK_CompanyFactoriesContractors_Companies1 FOREIGN KEY (CompanyID) REFERENCES Companies (CompanyID),
 CONSTRAINT FK_CompanyFactoriesContractors_Factories FOREIGN KEY (FactoryID) REFERENCES Factories (FactoryID),
 CONSTRAINT FK_CompanyFactoriesContractors_Companies2 FOREIGN KEY (ContractorID) REFERENCES Companies (CompanyID)
);

INSERT INTO Companies VALUES (1,'Tailoring Co');
INSERT INTO Companies VALUES (2,'Sewing Co');

INSERT INTO Companies VALUES (3,'Chinese Contractor');
INSERT INTO Companies VALUES (4,'Turkish Contractor');
INSERT INTO Companies VALUES (5,'Italian Contractor');
INSERT INTO Companies VALUES (6,'Eastern Contractor');
INSERT INTO Companies VALUES (7,'European Contractor');

INSERT INTO Factories VALUES (1,'Chinese clothes manufacturing');
INSERT INTO Factories VALUES (2,'Turkish clothes manufacturing');
INSERT INTO Factories VALUES (3,'Italian clothes manufacturing');

INSERT INTO CompanyFactoriesContractors VALUES (1, 2, 4);
INSERT INTO CompanyFactoriesContractors VALUES (1, 2, 6);
INSERT INTO CompanyFactoriesContractors VALUES (1, 3, 5);
INSERT INTO CompanyFactoriesContractors VALUES (1, 3, 7);

INSERT INTO CompanyFactoriesContractors VALUES (2, 1, 3);
INSERT INTO CompanyFactoriesContractors VALUES (2, 1, 6);
INSERT INTO CompanyFactoriesContractors VALUES (2, 2, 4);