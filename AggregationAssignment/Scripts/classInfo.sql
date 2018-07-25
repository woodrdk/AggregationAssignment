use master

IF DB_ID('ClassInfo') IS NOT NULL
	DROP DATABASE ClassInfo
GO

CREATE DATABASE ClassInfo
GO

USE ClassInfo
GO

CREATE TABLE Class
(
	ClassID	int	PRIMARY KEY IDENTITY
	,Credits int		NOT NULL
	,ClassNumber	varchar(35)	NOT NULL
	,Title		varchar(30)	NOT NULL
)
GO

INSERT INTO Class(Credits, ClassNumber,Title)
	VALUES('5', 'CPW 101', 'PROGRAMMING FUNDAMENTALS')
	,('5', 'CPW 116', '.NET PROGRAMMING')
	,('5', 'CPW 118', 'WEB DESIGN PRINCIPLES')
	,('5', 'CPW 142', 'JAVA OBJECT-ORIENTED PROGRAMMING')
	,('5', 'CPW 143', 'JAVA OBJECT-ORIENTED PROGRAMMING II')
	,('5', 'CPW 150', 'PRINCIPLES OF RELATIONAL DATABASES')
	,('5', 'CPW 203', 'ADVANCED JAVASCRIPT')
	,('5', 'CPW 205', 'OBJECT-ORIENTED ANALYSIS & DESIGN')
	,('5', 'CPW 210', 'ADVANCED DATABASE PROGRAMMING')
	,('5', 'CPW 212', 'ADVANCED .NET PROGRAMMING')
	,('5', 'CPW 213', '.NET WEB PROGRAMMING')
	,('5', 'CPW 215', 'ADVANCED .NET WEB PROGRAMMING')
	,('5', 'CPW 217', 'PORTFOLIO')
	,('5', 'CPW 218', 'C++')
	,('5', 'CPW 223', 'INTRODUCTION TO JAVASCRIPT')
	,('5', 'CPW 240', 'PROGRAMMING PRACTICUM')
	,('5', 'CPW 245', 'DATA & LOGIC STRUCTURES')
	,('5', 'CPW 252', 'PHONE PROGRAMMING')

	            
	    