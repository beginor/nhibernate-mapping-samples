CREATE TABLE Animal (
  Id INTEGER PRIMARY KEY,
  ClassType VARCHAR(128) NOT NULL,
  FoodClassification VARCHAR(128) NOT NULL,
  Breed VARCHAR(128),
  MaximumSpeed NUMERIC(4, 2),
  IsVenomous BOOLEAN,
  Length NUMERIC(5, 2),
 CHECK ((ClassType='Crocodile' OR ClassType='Snake' OR ClassType='Dog' OR ClassType='Horse')),
 CHECK ((FoodClassification='Carnivorous' OR FoodClassification='Herbivorous' OR FoodClassification='Omnivorous'))
);

INSERT INTO Animal VALUES (101, 'Crocodile','Carnivorous', NULL, NULL, NULL, 5);
INSERT INTO Animal VALUES (102, 'Snake','Carnivorous',NULL, NULL, 'TRUE', 4);
INSERT INTO Animal VALUES (103, 'Snake','Carnivorous',NULL, NULL, 'FALSE', 8);
INSERT INTO Animal VALUES (104, 'Dog','Omnivorous','Dalmatian', NULL, NULL, NULL);
INSERT INTO Animal VALUES (105, 'Horse','Herbivorous','Arabic', 70, NULL, NULL);