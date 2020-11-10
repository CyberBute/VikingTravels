USE VikingAssignment

/* 
    To keep the over all data more viewable Culoms with the same name in diffrent tables (such as Name in Carriers and Customers)
	are getting a character trait infront of them
	EXAMPLE:

	Customers(table)
	cust_Name
*/

/*
	The creation of the Customers table
*/
CREATE TABLE Customers
(
	cust_Id INT PRIMARY KEY,
	cust_FirstName NVARCHAR(255) NOT NULL,
	cust_LastName NVARCHAR(255) NOT NULL,
	cust_Address NVARCHAR(255)  NOT NULL,
	cust_Tel NVARCHAR(255) UNIQUE,
)

/*
	The creation of the Carriers table
*/
CREATE TABLE Carriers 
(
	carr_Id INT PRIMARY KEY,
	carr_FirstName NVARCHAR(255)  NOT NULL,
	carr_LastName NVARCHAR(255)  NOT NULL,
	carr_Address NVARCHAR(255)  NOT NULL,
	carr_Tel NVARCHAR(255) NOT NULL UNIQUE,
	remarks NVARCHAR(255)  NOT NULL
)

/*
	The creation of the Journey table
*/
CREATE TABLE Journey
(
	jour_Id INT PRIMARY KEY,
	title NVARCHAR(255)  NOT NULL,
	city NVARCHAR(255)  NOT NULL,
	startDate DATETIME  NOT NULL,
	endDate DATETIME  NOT NULL,
	jour_Carrier NVARCHAR(255),
	pricePerTravelers SMALLINT  NOT NULL,
	maxTravelers SMALLINT,
	_description NVARCHAR(255)  NOT NULL
)