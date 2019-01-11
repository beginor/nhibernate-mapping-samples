CREATE TABLE Animal (
  ID INTEGER PRIMARY KEY,
  FoodClassification VARCHAR(128) NOT NULL,
 CHECK ((FoodClassification='Carnivorous' OR FoodClassification='Herbivorous' OR FoodClassification='Omnivorous'))
);

CREATE TABLE Crocodile (
  ID INTEGER PRIMARY KEY,
  Length NUMERIC(5, 2),
 FOREIGN KEY (ID) REFERENCES Animal (ID)
);

CREATE TABLE Snake (
  ID INTEGER PRIMARY KEY,
  IsVenomous BOOLEAN,
  Length NUMERIC(5, 2),
 FOREIGN KEY (ID) REFERENCES Animal (ID)
);

CREATE TABLE Dog (
  ID INTEGER PRIMARY KEY,
  Breed VARCHAR(128) NOT NULL,
 FOREIGN KEY (ID) REFERENCES Animal (ID)
);

CREATE TABLE Horse (
  ID INTEGER PRIMARY KEY,
  Breed VARCHAR(128) NOT NULL,
  MaximumSpeed NUMERIC(4, 2),
 FOREIGN KEY (ID) REFERENCES Animal (ID)
);

INSERT INTO Animal VALUES (101, 'Carnivorous');
INSERT INTO Animal VALUES (102, 'Carnivorous');
INSERT INTO Animal VALUES (103, 'Carnivorous');
INSERT INTO Animal VALUES (104, 'Omnivorous');
INSERT INTO Animal VALUES (105, 'Herbivorous');

INSERT INTO Crocodile VALUES (101, 5);

INSERT INTO Snake VALUES (102,'TRUE', 4);
INSERT INTO Snake VALUES (103,'FALSE', 8);

INSERT INTO Dog VALUES (104,'Dalmatian');

INSERT INTO Horse VALUES (104,'Arabic',70);