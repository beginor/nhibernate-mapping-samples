CREATE TABLE Contact (
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  Phone СHAR(13),
 CONSTRAINT PK_Contact PRIMARY KEY (FirstName, LastName)
);

CREATE TABLE Person (
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  BirthDay DATE NOT NULL,
  Address VARCHAR(200) NOT NULL,
 CONSTRAINT PK_Person PRIMARY KEY (FirstName, LastName),
 CONSTRAINT FK_Person_Contact FOREIGN KEY (FirstName, LastName) REFERENCES Contact (FirstName, LastName)
);

INSERT INTO Contact VALUES ('Gustavo', 'Achong','398-555-0132');
INSERT INTO Contact VALUES ('Pilar','Ackerman','495-4789009');
INSERT INTO Contact VALUES ('Kim','Abercrombie','334-555-0137');
INSERT INTO Contact VALUES ('Humberto','Acevedo','599-555-0127');

INSERT INTO Person VALUES ('Gustavo', 'Achong','13-10-1984', 'Escuela Rural 45, Buenos Aires,Argentina');
INSERT INTO Person VALUES ('Pilar','Ackerman','28-03-1969','Ohotny Ryad av., 345b - 102, Moscow, Russia');
INSERT INTO Person VALUES ('Kim','Abercrombie','13-05-1977','36 BAOSHAN JIUCUN, BAOSHAN DISTRICT, Shanghai, China');
INSERT INTO Person VALUES ('Humberto','Acevedo','18-11-1987','3 High Street, Horsham, United Kingdom');