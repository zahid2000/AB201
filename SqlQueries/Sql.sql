--DDL

--CREATE DATABASE AB201

--ALTER DATABASE Students
--MODIFY NAME=AB201

--DROP DATABASE AB201

--USE AB201
CREATE TABLE Students(
Id  INT,
Name NVARCHAR(25),
Surname NVARCHAR(30),
Age INT
)

DROP TABLE Students

ALTER TABLE Students
ADD Email NVARCHAR(255)

ALTER TABLE Students
ALTER COLUMN Email NVARCHAR(25)

TRUNCATE TABLE Students

EXEC sp_rename People,Students
EXEC sp_renamedb AB202,AB201



--DML

--INSERT (CREATE)
	INSERT INTO Students
	VALUES
	(2,'Eli','Seferli',20,'Eli@code.edu.az'),
	INSERT INTO Students(Id,Name,Surname,Age) 
	VALUES
	(2,'Eli','Seferli',20),
    (3,'Hakim','Hebibli',20)



--SELECT (READ)
	--SELECT * FROM Students
	SELECT Id,Name,Surname From Students


-- UPDATE

UPDATE Students set Name='Hikmet' WHERE Id=2


--DELETE
  DELETE FROM Students WHERE Id=1




--Sql Constraint

CREATE TABLE Students(
Id  INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(30) DEFAULT('XXX'),
Email VARCHAR(255) UNIQUE,
Age INT,
CHECK(Age>=0 and Age<=100),
CHECK(LEN(Name)>2)
)

	INSERT INTO Students(Name,Age,Email)
	VALUES
	('Eli',200,'Eli11@code.edu.az')