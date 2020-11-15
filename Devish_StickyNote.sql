CREATE DATABASE Devish_Stickynotes;
USE Devish_Stickynotes;

CREATE TABLE Usertype
(
	Usertype_ID INT NOT NULL identity(1,1),
	Usertype_Name VARCHAR(30),
	CONSTRAINT pk_Usertype PRIMARY KEY(Usertype_ID)
);

CREATE TABLE Users
(
	Usertype_id INT,
	Users_ID INT NOT NULL identity(1,1),
	FirstName VARCHAR(20),
	LastName VARCHAR(20),
	Address_Name VARCHAR(20),
	Phone_No VARCHAR(20),
	Email VARCHAR (30),
	Gender VARCHAR(10),
	Username VARCHAR(50),
	Passcode VARCHAR(50), 
	CONSTRAINT pk_Users PRIMARY KEY(Users_ID),
	CONSTRAINT fk_Usertype FOREIGN KEY(Usertype_ID)
	REFERENCES Usertype
);

CREATE TABLE Categories
(
	Categories_ID INT NOT NULL identity(1,1),
	Categories_Name VARCHAR(10),
	CONSTRAINT pk_Categories PRIMARY KEY(Categories_ID)
);

CREATE TABLE StickyNotes
(
	StickyNotes_ID INT NOT NULL identity(1,1),
	Users_ID INT,
	Categories_ID INT,
	Date_Created DATE,
	Title VARCHAR(20),
	Content_of_Notes VARCHAR(200),
	IsStickied BIT,
	IsCompleted BIT,
	CONSTRAINT pk_StickyNotes PRIMARY KEY(StickyNotes_ID),
	CONSTRAINT fk_Users FOREIGN KEY (Users_ID)
	REFERENCES Users,
	CONSTRAINT fk_Categories FOREIGN KEY (Categories_ID)
	REFERENCES Categories,
);

SELECT * FROM Usertype;

SELECT * FROM Users;

SELECT * FROM Categories;

SELECT * FROM StickyNotes;