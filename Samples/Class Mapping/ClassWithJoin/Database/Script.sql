CREATE TABLE Orders (
  OrderID INTEGER PRIMARY KEY,
  Company VARCHAR(50),
  OrderDate DATETIME NOT NULL,
  Freight REAL,
  ShipDate DATETIME,
  Discount REAL
);

CREATE TABLE OrderDetails (
  OrderID INTEGER PRIMARY KEY,
  Product VARCHAR(50),
  Price REAL,
  Quantity REAL,
 CONSTRAINT OrderDetails_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

INSERT INTO Orders VALUES (1, 'Phone Co', '2006-08-06 00:00:00', 29, '2007-07-26 17:06:42', 20);
INSERT INTO Orders VALUES (2, 'Furniture Co', '2005-08-06 00:00:00', 24, '2007-07-13 17:06:51', 0);
INSERT INTO Orders VALUES (3, 'USB Co', '2004-07-06 00:00:00', 56, '2005-08-17 00:00:00', 45);
INSERT INTO Orders VALUES (4, 'Monitor Co', '2005-08-06 00:00:00', 154, '2005-08-20 00:00:00', 12);

INSERT INTO OrderDetails VALUES (1, 'Phone', 550, 25);
INSERT INTO OrderDetails VALUES (2, 'Sofa', 700, 22);
INSERT INTO OrderDetails VALUES (3, 'USB flash', 980, 10);
INSERT INTO OrderDetails VALUES (4, 'Monitor', 400, 29);
