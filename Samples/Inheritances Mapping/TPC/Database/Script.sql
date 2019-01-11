CREATE TABLE Snake (
  ID INTEGER PRIMARY KEY,
  FoodClassification VARCHAR(128) NOT NULL,
  Length NUMERIC(5, 2),
  IsVenomous BOOLEAN,
 CHECK ((FoodClassification='Carnivorous' OR FoodClassification='Herbivorous' OR FoodClassification='Omnivorous'))
);

CREATE TABLE Dog (
  ID INTEGER PRIMARY KEY,
  FoodClassification VARCHAR(128) NOT NULL,
  Breed VARCHAR(128) NOT NULL,
 CHECK ((FoodClassification='Carnivorous' OR FoodClassification='Herbivorous' OR FoodClassification='Omnivorous'))
);

INSERT INTO Snake VALUES (101,'Carnivorous',4,'TRUE');
INSERT INTO Snake VALUES (102,'Carnivorous',8,'FALSE');

INSERT INTO Dog VALUES (103,'Omnivorous','Dalmatian');
INSERT INTO Dog VALUES (104,'Omnivorous','Collie');