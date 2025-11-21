USE [master];

IF SCHEMA_ID(N'HR') IS NULL
   EXEC(N'CREATE SCHEMA HR;');
GO

IF SCHEMA_ID(N'Sales') IS NULL
   EXEC(N'CREATE SCHEMA Sales;');
GO

IF SCHEMA_ID(N'Production') IS NULL
   EXEC(N'CREATE SCHEMA Production;');
GO

IF OBJECT_ID(N'HR.Employee') IS NULL
BEGIN
	CREATE TABLE HR.Employee
	(
		EmployeeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ManagerID INT NULL,
		LastName NVARCHAR(30) NOT NULL,
		FirstName NVARCHAR(15) NOT NULL,
		DateOfBirth DATE NOT NULL,
		Title NVARCHAR(30) NOT NULL,
		DateOfHire DATE NOT NULL,
		[Status] NVARCHAR(10) NOT NULL,
		HourlyRate INT NOT NULL,

		CONSTRAINT UK_HR_Employee_Last_And_First_Name UNIQUE(LastName, FirstName)
	);
END;

IF OBJECT_ID(N'Sales.Customer') IS NULL
BEGIN
	CREATE TABLE Sales.Customer
	(
		CustID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		Email NVARCHAR(30) NOT NULL,
		LastName NVARCHAR(30) NOT NULL,
		FirstName NVARCHAR(30) NOT NULL,
		Phone NVARCHAR(10) NOT NULL,
		[Address] NVARCHAR(60) NOT NULL,
		City NVARCHAR(20) NOT NULL,
		[State] NVARCHAR(20) NOT NULL,
		ZipCode NVARCHAR(5) NOT NULL,
		[Status] NVARCHAR(10) NULL,

		CONSTRAINT UK_Sales_Customer_Email UNIQUE (Email),

		CONSTRAINT UK_Sales_Customer_Last_and_First_Name UNIQUE (LastName, FirstName)


	);
END;

IF OBJECT_ID(N'Sales.ProjectPropsal') IS NULL
BEGIN
	CREATE TABLE Sales.ProjectProposal
	(
		ProjectProposalID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ProjectName NVARCHAR(80) NOT NULL,
		ProjectDetails NVARCHAR(500) NOT NULL,
		CustID INT NOT NULL,
		EstimatedDurationHours INT NOT NULL,
		[Status] NVARCHAR(10) NOT NULL,
		--add employeeID need to talk about

		CONSTRAINT FK1_Sales_ProjectProposal_CustID FOREIGN KEY(CustID)
			REFERENCES Sales.Customer(CustID), 

		CONSTRAINT UK_Sales_ProjectPropsal_Project_Name UNIQUE (ProjectName)
	);
END;

IF OBJECT_ID(N'Production.Project') IS NULL
BEGIN
	CREATE TABLE Production.Project
	(
		ProjectID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		CustomerID INT NOT NULL,
		ProjectName NVARCHAR(20) NOT NULL,
		StartDate DATE NOT NULL,
		EndDate DATE NULL,
		ManagerID INT NOT NULL,
		[Status] NVARCHAR(10) NULL,

		CONSTRAINT FK1_Production_Project_CustomerID FOREIGN KEY(CustomerID)
			REFERENCES Sales.Customer(CustomerID),

		CONSTRAINT FK2_Production_Project_ManagerID FOREIGN KEY(ManagerID)
			REFERENCES HR.Employee(ManagerID),

		CONSTRAINT UK_Production_Project_Project_Name UNIQUE(ProjectName)
	);
END;

IF OBJECT_ID(N'Production.ProjectRateType') IS NULL
BEGIN
	CREATE TABLE Production.ProjectRateType
	(
		RateID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ProjectID INT NOT NULL,
		HourlyRate INT NOT NULL,
		StartDate DATE NOT NULL,
		ENDDate Date NULL,

		CONSTRAINT FK_Produciton_ProjectRateType_ProjectID FOREIGN KEY(ProjectID)
			REFERENCES Production.Project(ProjectID)
	);
END;

IF OBJECT_ID(N'Production.ProjectMaterials') IS NULL
BEGIN
	CREATE TABLE Produciton.ProjectMaterials
	(
		MaterialID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ProjectID INT NOT NULL,
		[Description] NVARCHAR(40) NOT NULL,
		Quanity INT NOT NULL,
		Total INT NOT NULL,

		CONSTRAINT FK_Production_ProjectMaterials_ProjectID FOREIGN KEY(ProjectID)
			REFERENCES Production.Project(ProjectID)
	);
END;

IF OBJECT_ID(N'Production.ProjectHours') IS NULL
BEGIN
	CREATE TABLE Production.ProjectHours
	(
		ProjectHoursID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ProjectID INT NOT NULL,
		ManagerID INT NOT NULL,
		[Description] NVARCHAR(80) NOT NULL,
		WorkPerformedDate DATE NOT NULL,
		[Hours] INT NOT NULL,

		CONSTRAINT FK_Production_ProjectHours_ProjectID FOREIGN KEY(ProjectID)
			REFERENCES Production.Project(ProjectID)
	);
END;