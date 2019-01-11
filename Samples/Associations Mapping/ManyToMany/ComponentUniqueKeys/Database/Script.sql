CREATE TABLE Companies (
  CompanyID INTEGER PRIMARY KEY,
  CompanyName VARCHAR(15) NOT NULL,
  CompanyPhone VARCHAR(20) NOT NULL,
 CONSTRAINT UK_Companies UNIQUE (CompanyName, CompanyPhone)
);

CREATE TABLE Factories (
  FactoryID INTEGER PRIMARY KEY,
  FactoryName VARCHAR(15) NOT NULL,
  FactoryPhone VARCHAR(20) NOT NULL,
 CONSTRAINT UK_Factories UNIQUE (FactoryName, FactoryPhone)
);

CREATE TABLE CompanyFactories (
  CompanyName VARCHAR(15) NOT NULL,
  CompanyPhone VARCHAR(20) NOT NULL,
  FactoryName VARCHAR(15) NOT NULL,
  FactoryPhone VARCHAR(20) NOT NULL,
 CONSTRAINT PK_CompanyFactories PRIMARY KEY (CompanyName, CompanyPhone, FactoryName, FactoryPhone),
 CONSTRAINT FK_CompanyFactories_Companies FOREIGN KEY (CompanyName, CompanyPhone) REFERENCES Companies (CompanyName, CompanyPhone),
 CONSTRAINT FK_CompanyFactories_Factories FOREIGN KEY (FactoryName, FactoryPhone) REFERENCES Factories (FactoryName, FactoryPhone)
);

INSERT INTO Companies VALUES (1,'Tailoring Co','(212) 714 - 9070');
INSERT INTO Companies VALUES (2,'Sewing Co','(192) 711 - 7061');

INSERT INTO Factories VALUES (1,'Chinese clothes manufacturing','(144) 371 - 2783');
INSERT INTO Factories VALUES (2,'Turkish clothes manufacturing','(251) 532 - 7765');
INSERT INTO Factories VALUES (3,'Italian clothes manufacturing','(099) 111 - 3448');

INSERT INTO CompanyFactories VALUES ('Tailoring Co','(212) 714 - 9070','Turkish clothes manufacturing','(251) 532 - 7765');
INSERT INTO CompanyFactories VALUES ('Tailoring Co','(212) 714 - 9070','Italian clothes manufacturing','(099) 111 - 3448');
INSERT INTO CompanyFactories VALUES ('Sewing Co','(192) 711 - 7061','Chinese clothes manufacturing','(144) 371 - 2783');
INSERT INTO CompanyFactories VALUES ('Sewing Co','(192) 711 - 7061','Turkish clothes manufacturing','(251) 532 - 7765');