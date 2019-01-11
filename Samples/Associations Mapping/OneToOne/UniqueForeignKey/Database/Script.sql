CREATE TABLE Contact (
  ContactID INTEGER PRIMARY KEY,
  Name VARCHAR(100) NOT NULL,
  Phone СHAR(13)
);

CREATE TABLE Person (
  PersonID INTEGER PRIMARY KEY,
  ContactID INTEGER,
  BirthDay DATE NOT NULL,
  Address VARCHAR(200) NOT NULL,
 CONSTRAINT UK_Person_ContactID UNIQUE (ContactID),
 CONSTRAINT FK_PERSON_CONTACT FOREIGN KEY (PersonID) REFERENCES Contact (ContactID)
);

INSERT INTO Contact VALUES (1,'Gustavo Achong','398-555-0132');
INSERT INTO Contact VALUES (2,'Pilar Ackerman','495-4789009');
INSERT INTO Contact VALUES (3,'Kim Abercrombie','334-555-0137');
INSERT INTO Contact VALUES (4,'Humberto Acevedo','599-555-0127');

INSERT INTO Person VALUES (101,1,'13-10-1984', 'Escuela Rural 45, Buenos Aires,Argentina');
INSERT INTO Person VALUES (102,2,'28-03-1969','Ohotny Ryad av., 345b - 102, Moscow, Russia');
INSERT INTO Person VALUES (103,3,'13-05-1977','36 BAOSHAN JIUCUN, BAOSHAN DISTRICT, Shanghai, China');
INSERT INTO Person VALUES (104,4,'18-11-1987','3 High Street, Horsham, United Kingdom');