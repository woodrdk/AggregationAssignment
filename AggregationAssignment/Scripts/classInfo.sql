use master

IF DB_ID('ClassInfo') IS NOT NULL
	DROP DATABASE ClassInfo
GO

CREATE DATABASE ClassInfo
GO

USE ClassInfo
GO
	            
CREATE TABLE Instructor
(
	InstID	int	PRIMARY KEY IDENTITY
	,Name				varchar(50)	NOT NULL
	,Email				varchar(50)	NOT NULL
	,OfficeLocation		varchar(50)	NOT NULL
)
GO

INSERT INTO Instructor(Name, Email, OfficeLocation)
	VALUES('Joseph Ortiz', 'joseph.ortiz@cptc.edu', '11-111E')
	,('Kenneth Meerdink', 'kenneth.meerdink@cptc.edu', '11-111W')

CREATE TABLE Class
(
	ClassID	int	PRIMARY KEY IDENTITY
	,Credits int		NOT NULL
	,ClassNumber	varchar(35)	NOT NULL
	,Title		varchar(50)	NOT NULL
	,CLDescription		varchar(5000)	NOT NULL
	,InstID int Foreign KEY References Instructor(InstID)
)
GO

INSERT INTO Class(Credits, ClassNumber,Title, CLDescription,InstID)
	VALUES('5', 'CPW 101', 'PROGRAMMING FUNDAMENTALS', 'This course is an introduction to programming concepts that enforces good programming style and logical thinking. Designed for students with little or no programming language experience, it begins with basic general programming concepts and key concepts of structure. The course then progresses to the intricacies of decision-making, looping, array manipulation, and methods. ', 2)
	,('5', 'CPW 116', '.NET PROGRAMMING', 'Create programs using the .NET Framework with focus on desktop and console applications. Use decision structures, loops, and arrays to solve problems. Apply exception handling and data validation to programs. Use the predefined libraries in .NET Framework to solve problems. Create methods and learn to pass and return arguments. Create classes and use the classes as objects in programming. Use databases to store and retrieve the data from the applications. ', 1)
	,('5', 'CPW 118', 'WEB DESIGN PRINCIPLES', 'Explores how the web works and methods and limitations of delivering content on the web. Examines usability issues such as interface design and structure, and how to accommodate a wide variety of viewports, from smartphones to cinema screen computer monitors. Students will build a four-page portfolio style website using Notepad and Photoshop, and post it to the Internet.' ,1)
	,('5', 'CPW 142', 'JAVA OBJECT-ORIENTED PROGRAMMING', 'Construct a foundation of procedural programming concepts and skills requisite for professional object-oriented software development. Use Java, a modern-structured, object-oriented language, to develop your problem-solving and algorithm formulation skills. ',2)
	,('5', 'CPW 143', 'JAVA OBJECT-ORIENTED PROGRAMMING II', 'Build your problem-solving skills with the fundamental concepts and techniques of object-oriented Java programming in analyzing, designing, and implementing computer programs. Practice problem-solving methods and algorithm development to analyze, design, implement, modify, verify, and document computer programs that solve real-world problems. Develop a good conceptual understanding of data and functional abstraction. ',1)
	,('5', 'CPW 150', 'PRINCIPLES OF RELATIONAL DATABASES', 'Delve into the fundamental concepts, terminologies, methodologies, and system organizations of database management systems. Develop the theoretical foundation of understanding necessary to design, implement, optimize, query, and maintain a database system. Propose, design and develop a database, using a relational database management system to reinforce the theoretical concepts. ',1)
	,('5', 'CPW 203', 'ADVANCED JAVASCRIPT', 'Reinforce fundamentals and create larger applications using JavaScript. Dive deeper into event-driven programming. Update web pages dynamically by manipulating the HTML Document Object Model (DOM). Learn how to integrate existing JavaScript libraries and frameworks into your applications.',1 )
	,('5', 'CPW 205', 'OBJECT-ORIENTED ANALYSIS & DESIGN', 'Explore methodologies and technologies used in analyzing, designing and developing object-oriented software systems intended to solve real-world problems. Build on the Systems Development Life Cycle model initially presented in the CPW 101 course to model and design systems using tools such as CRC cards and the Unified Modeling Language, which includes class, use case, and sequence diagrams. Discuss the theoretical and practical aspects of object orientation. ',2)
	,('5', 'CPW 210', 'ADVANCED DATABASE PROGRAMMING', 'Advanced database programming using a commercial relational database management system. Perform object creation, manipulation and control using SQL. Write simple and complex queries to solve problems. Create advanced objects like stored procedures and triggers. Explore non-relational systems and business intelligence.',1)
	,('5', 'CPW 212', 'ADVANCED .NET PROGRAMMING', 'Learn advanced .NET programming — writing classes, working with indexers, overloading operators, and other advanced object-oriented concepts. Work with databases using ADO.NET, databinding, and object-relational mappers. Learn techniques for working non-relational data storage.',1)
	,('5', 'CPW 213', '.NET WEB PROGRAMMING', 'Learn advanced .NET programming — writing classes, working with indexers, overloading operators, and other advanced object-oriented concepts. Work with databases using ADO.NET, databinding, and object-relational mappers. Learn techniques for working non-relational data storage.',1)
	,('5', 'CPW 215', 'ADVANCED .NET WEB PROGRAMMING', 'Learn advanced .NET programming — writing classes, working with indexers, overloading operators, and other advanced object-oriented concepts. Work with databases using ADO.NET, databinding, and object-relational mappers. Learn techniques for working non-relational data storage.',1)
	,('5', 'CPW 217', 'PORTFOLIO', 'Build a portfolio website showcasing skills developed in the Computer Programming and Web Development program. Create a fully functional website from start to finish. Analyze and derive requirements by creating a project proposal or by working with an actual client. Larger projects will utilize source control and emphasize team work.',1)
	,('5', 'CPW 218', 'C++', 'Deals with learning programming using C++ as the primary language with a focus on problem-solving and introduction to object-oriented concepts and terms. ',2)
	,('5', 'CPW 223', 'INTRODUCTION TO JAVASCRIPT', 'Introduces the fundamentals of working with JavaScript. Applies variables, objects, arrays, strings, conditional statements, and external data to create dynamic, interactive web pages. ',1)
	,('5', 'CPW 240', 'PROGRAMMING PRACTICUM', 'Programming on a medium-scale in object-oriented development, consolidating prior programming principles and expanding knowledge of application design. This course introduces students to some concepts of advanced programming. Topics may include Graphical User Interface (GUI), Java Database Connectivity (JDBC), multithreading, inner classes, collections, exceptions, file I/O (NIO), networking, reflection, Swing, Remote Method Invocation (RMI), Naming Service (JNDI), Serialization, Servlets, and JavaServer Pages (JSP).',2)
	,('5', 'CPW 245', 'DATA & LOGIC STRUCTURES', 'Expand your understanding of object-oriented programming techniques by implementing abstract data types as data structures in solving complex computing problems. Study the fundamental algorithms of computer science while using mathematical principles to analyze the efficiency of their implementation. ',2)
	,('5', 'CPW 252', 'PHONE PROGRAMMING', 'Covers the concepts involved with programming on the phone — source control, phone emulators, phone APIs, and deployment. ',2)


CREATE TABLE Students
(
	StudentID	int	PRIMARY KEY IDENTITY
	,FirstName			varchar(50)	NOT NULL
	,LastName			varchar(50)	NOT NULL
)

INSERT INTO Students(FirstName, LastName)
	VALUES('Robert', 'Wood')
	,('Anthony', 'McCann')
	,('Anthony', 'Ardiente')
	,('Krista', 'Betcher' )
	,('Nicholas', 'Carranza')
	,('Amysha', 'Dixon')
	,('Casey', 'Gruse' )
	,('Jeanna', 'Kawamoto')
	,('Michelle', 'Mcgowan' )
	,('Jake', 'Mettler')
	,('Nelson', 'Nyland' )
	,('Nicholas', 'Olmstead')
	,('Dakota', 'Tominus')


CREATE TABLE ClassesIn
(
	StudentID		int Foreign KEY References Students(StudentID) Not Null
	,ClassID		int Foreign KEY References Class(ClassID) Not Null
	,Primary Key (StudentID, ClassID)
)

INSERT INTO ClassesIn(StudentID, ClassID)
	VALUES(1, 10)
	,(1,11)
	,(1,17)

	,(2,10)
	,(2,11)
	,(2,17)
	
	,(3,3)
	,(3,4)
	,(3,2)

	,(4,10)
	,(4,11)
	,(4,17)
	
	,(5,10)
	,(5,11)
	,(5,4)	
	
	,(6,10)
	,(6,11)
	,(6,17)

	,(7,10)
	,(7,11)
	,(7,17)
	
	,(8,10)
	,(8,11)
	,(8,3)
	
	,(9,10)
	,(9,11)
	,(9,17)

	,(10,10)
	,(10,11)
	,(10,17)	

	,(11,10)
	,(11,11)
	,(11,17)	

	,(12, 6)
	,(12,3)
	,(12,8)	

	,(13, 10)
	,(13,11)
	,(13,17)