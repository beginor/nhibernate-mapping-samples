CREATE TABLE Orders (
  OrderID INTEGER PRIMARY KEY,
  Company VARCHAR(50)
);

CREATE TABLE OrderDetails (
  OrderID INTEGER PRIMARY KEY,
  Product VARCHAR(50),
  Price REAL,
 CONSTRAINT FK_OrderDetails_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE OrderImplementers (
  ImplementerID INTEGER PRIMARY KEY,
  Name VARCHAR(50),
  OrderID INTEGER,
 CONSTRAINT FK_PersonRecipients_OrderDetails FOREIGN KEY (OrderID) REFERENCES OrderDetails(OrderID)
);

INSERT INTO Orders VALUES (1, 'Phone Co');
INSERT INTO Orders VALUES (2, 'Monitor Co');

INSERT INTO OrderDetails VALUES (1, 'Phone', 980);
INSERT INTO OrderDetails VALUES (2, 'Monitor', 400);

INSERT INTO OrderImplementers VALUES (1, 'SMITH MENSON', 1);
INSERT INTO OrderImplementers VALUES (2, 'ALLEN RUDD', 1);
INSERT INTO OrderImplementers VALUES (3, 'WARD GODWIN', 2);
INSERT INTO OrderImplementers VALUES (4, 'JONES FREEMAN', 2);