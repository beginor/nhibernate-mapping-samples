CREATE TABLE Conversation (
  Id INTEGER PRIMARY KEY,
  Description VARCHAR(40)
);


CREATE TABLE Message (
  Id INTEGER PRIMARY KEY,
  "Order" INTEGER,
  Text VARCHAR(14),
  ConversationId INTEGER NOT NULL,
 CONSTRAINT FK_Message_Conversation FOREIGN KEY (ConversationId) REFERENCES Conversation (Id)
);

INSERT INTO Conversation VALUES (10,'NHibernate collection mappings');
INSERT INTO Conversation VALUES (20,'NHibernate inheritance mapping strategies');
INSERT INTO Conversation VALUES (30,'Fluent NHibernate');

INSERT INTO Message VALUES (100, 1, 'Set is an unordered collection of unique entities.',10);
INSERT INTO Message VALUES (101, 2,'Bag is an unordered collection of entities.',10);
INSERT INTO Message VALUES (102, 0,'Map is an unordered collection of entities.',10);
INSERT INTO Message VALUES (103, 0,'The TPH inheritance depends on a conditional mapping which is defined by a condition such as a discriminator database field.',20);