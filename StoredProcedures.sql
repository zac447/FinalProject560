--Core Procedures per table


--Customer Procedures

--Add new customer. 
--Demonstrates: INSERT, strings + ints, identity key.
CREATE PROCEDURE Add_Customer 
	@Email NVARCHAR(50), @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @Phone NVARCHAR(10), 
	@Address NVARCHAR(60), @City NVARCHAR(20), @State NVARCHAR(20), @ZipCode NVARCHAR(5), @Status NVARCHAR(10)
AS 
BEGIN
	INSERT INTO Sales.Customer 
	(Email, LastName, FirstName, Phone, [Address], City, [State], ZipCode, [Status])

VALUES (@Email, @LastName, @FirstName, @Phone, @Address, @City, @State, @ZipCode, @Status)
END;	
GO;

EXEC Add_Customer 
    @Email = 'testproc@gmail.com',
    @LastName = 'Smith',
    @FirstName = 'John',
    @Phone = '5551234567',
    @Address = '123 Main St',
    @City = 'Kansas City',
    @State = 'MO',
    @ZipCode = '64101',
    @Status = 'Active';

SELECT * FROM Sales.Customer

--Update customer contact info
--Demonstrates: UPDATE, use of primary key.
CREATE PROCEDURE Update_Customer 
	@CustomerID INT, @Email NVARCHAR(50), @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @Phone NVARCHAR(10), 
	@Address NVARCHAR(60), @City NVARCHAR(20), @State NVARCHAR(20), @ZipCode NVARCHAR(5), @Status NVARCHAR(10)
AS 
BEGIN
	UPDATE Sales.Customer 
	SET Email = @Email, LastName = @LastName, FirstName = @FirstName, Phone = @Phone, [Address] = @Address, 
		City = @City, [State] = @State, ZipCode = @ZipCode, [Status] = @Status
	WHERE CustomerID = @CustomerID AND 
	( Email    <> @Email
     OR LastName <> @LastName
     OR FirstName <> @FirstName
     OR Phone    <> @Phone
     OR [Address]<> @Address
     OR City     <> @City
     OR [State]  <> @State
     OR ZipCode  <> @ZipCode
     OR [Status] <> @Status
     );

END;	
GO

EXEC Update_Customer
	@CustomerID = 101,
	@Email = 'Brian.Ortega@gmail.com',
    @LastName = 'Ortega',
    @FirstName = 'Brian',
    @Phone = '5551234567',
    @Address = '123 Main St',
    @City = 'Top City City',
    @State = 'MO',
    @ZipCode = '66614',
    @Status = 'Active';

--Soft-delete customer
--Demonstrates: soft delete requirement.
CREATE PROCEDURE Deactivate_Customer 
	@CustomerID INT
AS 
BEGIN
	UPDATE Sales.Customer 
	SET [Status] = 'Inactive'
	WHERE CustomerID = @CustomerID AND [Status] = 'Active'

END;	
GO

EXEC Deactivate_Customer
	@CustomerID = 101;

	
--Search customers
--Demonstrates: searching/listing records.
CREATE PROCEDURE Search_Customer
	@CustomerID INT = NULL, @LastName NVARCHAR(30) = NULL, @FirstName NVARCHAR(30) = NULL, @City NVARCHAR(20) = NULL, @Status NVARCHAR(20) = NULL
AS 
BEGIN
	SELECT * 
	FROM Sales.Customer
	WHERE (@CustomerID IS NULL OR CustomerID = @CustomerID) AND (@LastName IS NULL OR LastName = @LastName) AND (@FirstName IS NULL OR FirstName = @FirstName) 
	AND (@City IS NULL OR City =  @City) AND (@Status IS NULL OR Status = @Status)

END;	
GO

EXEC Search_Customer
	@Status = 'Inactive';


--Employee Procedures

--Add new employee
--Demonstrates: INSERT, strings + ints, identity key.
CREATE PROCEDURE Add_Employee 
	@ManagerID INT, @LastName NVARCHAR(30), @FirstName NVARCHAR(15), @DateOfBirth DATE, 
	@Title NVARCHAR(30), @DateOfHire DATE, @Status NVARCHAR(10), @HourlyRate DECIMAL(10,2)
AS 
BEGIN
	INSERT INTO HR.Employee
	(ManagerID, LastName, FirstName, DateOfBirth, Title, DateOfHire, [Status], HourlyRate)

VALUES (@ManagerID, @LastName, @FirstName, @DateOfBirth, @Title, @DateOfHire, @Status, @HourlyRate)
END;	
GO

EXEC Add_Employee  
    @ManagerID = NULL,
    @LastName = 'Burges',
    @FirstName = 'Clayton',
    @DateOfBirth = '2000-01-01',
	@Title = 'Senior Programer',
    @DateOfHire = '2025-01-01',
    @Status = 'Active',
	@HourlyRate = 35.50;

SELECT * FROM HR.Employee

--Update employee info
--Demonstrates: UPDATE, use of primary key.
CREATE PROCEDURE Update_Employee 
	@EmployeeID INT, @ManagerID INT, @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @DateOfBirth DATE, @Title NVARCHAR(30) , @Status NVARCHAR(10), @HourlyRate DECIMAL(10,2)
AS 
BEGIN
	UPDATE HR.Employee 
	SET ManagerID = @ManagerID, LastName = @LastName, FirstName = @FirstName, DateOfBirth = @DateOfBirth, Title = @Title , [Status] = @Status, HourlyRate = @HourlyRate 
	WHERE EmployeeID = @EmployeeID AND 
	( ManagerID <> @ManagerID
     OR LastName <> @LastName
     OR FirstName <> @FirstName
     OR DateOfBirth <> @DateOfBirth
     OR Title <> @Title
     OR [Status] <> @Status
	 OR HourlyRate <> @HourlyRate
     );

END;	
GO

EXEC Update_Employee
	@EmployeeID = 101,
	@ManagerID = 102,
    @LastName = 'Atchison',
    @FirstName = 'Zac',
    @DateOfBirth = '2004-01-01',
    @Title = 'A Big Dawg',
    @Status = 'Active',
    @HourlyRate = 40.00;

SELECT * FROM HR.Employee

--Soft-delete employee
--Demonstrates: soft delete requirement.
CREATE PROCEDURE Deactivate_Employee
	@EmployeeID INT
AS 
BEGIN
	UPDATE HR.Employee
	SET [Status] = 'Inactive'
	WHERE EmployeeID = @EmployeeID AND [Status] = 'Active' OR [Status] = 'On Leave'

END;	
GO

EXEC Deactivate_Employee
	@EmployeeID = 96;

SELECT * FROM HR.Employee
	
--Search Employees
--Demonstrates: searching/listing records.
CREATE PROCEDURE Search_Employee
	@EmployeeID INT = NULL, @ManagerID INT = NULL, @LastName NVARCHAR(30) = NULL, @FirstName NVARCHAR(30) = NULL, @DateOfBirth DATE = NULL, @Title NVARCHAR(30) = NULL, 
	@DateOfHire DATE = NULL, @Status NVARCHAR(10) = NULL, @HourlyRate DECIMAL(10,2) = NULL
AS 
BEGIN
	SELECT * 
	FROM HR.Employee
	WHERE (@EmployeeID IS NULL OR EmployeeID = @EmployeeID) AND (@ManagerID IS NULL OR ManagerID = @ManagerID) AND (@LastName IS NULL OR LastName = @LastName) 
		AND (@FirstName IS NULL OR FirstName = @FirstName) AND (@DateOfBirth IS NULL OR DateOfBirth =  @DateOfBirth) 
		AND (@Title IS NULL OR Title = @Title) AND (@DateOfHire IS NULL OR DateOfHire = @DateOfHire) AND (@Status IS NULL OR Status = @Status)
		AND (@HourlyRate IS NULL OR HourlyRate = @HourlyRate)
END;	
GO

EXEC Search_Employee
	@LastName = 'Wynn';

--Project Proposal Procedures

--Add new project proposal. 
--Demonstrates: INSERT into a table with FK to Sales.Customer.
CREATE PROCEDURE Add_Proposal
	@Email NVARCHAR(50), @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @Phone NVARCHAR(10), 
	@Address NVARCHAR(60), @City NVARCHAR(20), @State NVARCHAR(20), @ZipCode NVARCHAR(5), @Status NVARCHAR(10)
AS 
BEGIN
	INSERT INTO Sales.Customer 
	(Email, LastName, FirstName, Phone, [Address], City, [State], ZipCode, [Status])

VALUES (@Email, @LastName, @FirstName, @Phone, @Address, @City, @State, @ZipCode, @Status)
END;	
GO;

EXEC Add_Proposal
    @Email = 'testproc@gmail.com',
    @LastName = 'Smith',
    @FirstName = 'John',
    @Phone = '5551234567',
    @Address = '123 Main St',
    @City = 'Kansas City',
    @State = 'MO',
    @ZipCode = '64101',
    @Status = 'Active';

SELECT * FROM Sales.Customer

--Update customer contact info
--Demonstrates: UPDATE, use of primary key.
CREATE PROCEDURE Update_Customer 
	@CustomerID INT, @Email NVARCHAR(50), @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @Phone NVARCHAR(10), 
	@Address NVARCHAR(60), @City NVARCHAR(20), @State NVARCHAR(20), @ZipCode NVARCHAR(5), @Status NVARCHAR(10)
AS 
BEGIN
	UPDATE Sales.Customer 
	SET Email = @Email, LastName = @LastName, FirstName = @FirstName, Phone = @Phone, [Address] = @Address, 
		City = @City, [State] = @State, ZipCode = @ZipCode, [Status] = @Status
	WHERE CustomerID = @CustomerID AND 
	( Email    <> @Email
     OR LastName <> @LastName
     OR FirstName <> @FirstName
     OR Phone    <> @Phone
     OR [Address]<> @Address
     OR City     <> @City
     OR [State]  <> @State
     OR ZipCode  <> @ZipCode
     OR [Status] <> @Status
     );

END;	
GO

EXEC Update_Customer
	@CustomerID = 101,
	@Email = 'Brian.Ortega@gmail.com',
    @LastName = 'Ortega',
    @FirstName = 'Brian',
    @Phone = '5551234567',
    @Address = '123 Main St',
    @City = 'Top City City',
    @State = 'MO',
    @ZipCode = '66614',
    @Status = 'Active';

--Soft-delete customer
--Demonstrates: soft delete requirement.
CREATE PROCEDURE Deactivate_Customer 
	@CustomerID INT
AS 
BEGIN
	UPDATE Sales.Customer 
	SET [Status] = 'Inactive'
	WHERE CustomerID = @CustomerID AND [Status] = 'Active'

END;	
GO

EXEC Deactivate_Customer
	@CustomerID = 101;

	
--Search customers
--Demonstrates: searching/listing records.
CREATE PROCEDURE Search_Customer
	@CustomerID INT = NULL, @LastName NVARCHAR(30) = NULL, @FirstName NVARCHAR(30) = NULL, @City NVARCHAR(20) = NULL, @Status NVARCHAR(20) = NULL
AS 
BEGIN
	SELECT * 
	FROM Sales.Customer
	WHERE (@CustomerID IS NULL OR CustomerID = @CustomerID) AND (@LastName IS NULL OR LastName = @LastName) AND (@FirstName IS NULL OR FirstName = @FirstName) 
	AND (@City IS NULL OR City =  @City) AND (@Status IS NULL OR Status = @Status)

END;	
GO

EXEC Search_Customer
	@Status = 'Inactive';

	
--Project Proposal Procedures

--Add new project proposal. 
--Demonstrates: INSERT into a table with FK to Sales.Customer.
CREATE PROCEDURE Add_Proposal
	@ProjectName NVARCHAR(80), @ProjectDetails NVARCHAR(500), @CustomerID INT, @EstimatedDurationHours INT, @Status NVARCHAR(10)
AS 
BEGIN
	INSERT INTO Sales.ProjectProposal
	(ProjectName, ProjectDetails, CustomerID, EstimatedDurationHours, [Status])

VALUES (@ProjectName, @ProjectDetails, @CustomerID, @EstimatedDurationHours, @Status)
END;	
GO

EXEC Add_Proposal
    @Projectname = '560 Database',
    @ProjectDetails = 'Create a working database',
    @CustomerID = 100,
    @EstimatedDurationHours = 40,
    @Status = 'Approved';

SELECT * FROM Sales.Customer
SELECT * FROM Sales.ProjectProposal

--Update proposal status
--Demonstrates: business state changes with UPDATE.
CREATE PROCEDURE Update_Proposal_Status
	@ProposalID INT, @Status NVARCHAR(10)
AS 
BEGIN
	UPDATE Sales.ProjectProposal
	SET [Status] = @Status
	WHERE ProjectProposalID = @ProposalID 
END;	
GO

EXEC Update_Proposal_Status
	@ProposalID = 104,
    @Status = 'Declined';

SELECT * FROM Sales.ProjectProposal

--List proposals by status / customer
--Demonstrates: SELECT with JOIN, search/filter.
CREATE PROCEDURE List_Proposal_By_Status_OR_Customer
	@CustomerID INT = NULL, @Status NVARCHAR(10) = NULL
AS 
BEGIN
	SELECT C.CustomerID, PP.Status ,C.FirstName + ' ' + C.LastName AS FullName, PP.ProjectProposalID, PP.ProjectName, PP.ProjectDetails
	FROM Sales.ProjectProposal PP 
		JOIN Sales.Customer C ON PP.CustomerID = C.CustomerID
	WHERE C.CustomerID = @CustomerID OR PP.Status = @Status 
	ORDER BY PP.Status, C.LastName ASC, C.FirstName ASC

END;	
GO

EXEC List_Proposal_By_Status_OR_Customer
	
	@Status = Proposed;

SELECT * FROM Sales.ProjectProposal

--Project Procedures

--Create project from an approved proposal
--Demonstrates: INSERT based on another table, JOIN/SELECT inside procedure, foreign keys working.

CREATE PROCEDURE Add_Project
	@ProjectProposalID INT, @ManagerID INT, @StartDate DATE, @Status NVARCHAR(10)
AS 
BEGIN
	WITH CTE AS(
		SELECT PP.ProjectName, C.CustomerID 
		FROM Sales.ProjectProposal PP 
			JOIN Sales.Customer C ON PP.CustomerID = C.CustomerID
		WHERE PP.ProjectProposalID = @ProjectProposalID
	)
	INSERT INTO Production.Project
	(CustomerID, ProjectName, StartDate, EndDate, ManagerID, [Status])
	SELECT CustomerID,
           ProjectName,
           @StartDate,
           NULL,
           @ManagerID,
           @Status
    FROM CTE;
END;	
GO

EXEC Add_Project
    @ProjectProposalID = 2,
    @ManagerID = 2,
	@StartDate = '2025-11-29',
	@Status = 'NotStarted';

SELECT * FROM Production.Project

--Update project status and end date
--Demonstrates: UPDATE, date handling.
CREATE PROCEDURE Update_Project_Status
	@ProjectID INT, @Status NVARCHAR(10)
AS 
BEGIN 
	UPDATE Production.Project
	SET [Status] = @Status, 
	EndDate = CASE
		WHEN @Status = 'Completed' AND EndDate IS NULL THEN GETDATE()
		ELSE EndDate
		END
	WHERE ProjectID = @ProjectID 
END;	
GO

EXEC Update_Project_Status
	@ProjectID = 100,
    @Status = 'Completed';	

SELECT * FROM Production.Project

--Search Projects
--Demonstrates: multi-table JOIN search.
CREATE PROCEDURE Search_Projects
	@CustomerName NVARCHAR(80) = NULL,@ManagerID INT = NULL ,@Status NVARCHAR(10) = NULL
AS 
BEGIN
	SELECT C.FirstName + ' ' + C.LastName AS FullCustomerName, P.ProjectName, 
	C.Address + ' ' + C.City + ' ' + C.State AS FullCustomerAddress, C.ZipCode ,E.FirstName + ' ' + E.LastName AS Manager,
		P.[Status], P.StartDate, P.EndDate 
	FROM Production.Project P 
		JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
		JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
	WHERE C.FirstName = @CustomerName OR E.EmployeeID = @ManagerID OR P.Status = @Status 
	ORDER BY FullCustomerName ASC,ProjectName ASC ,EmployeeID ASC

END;	
GO

EXEC Search_Projects
	@Status = InProgress;

--Project Hours Procedures

--Log hours worked on a project
--Demonstrates: INSERT with FK to Project and Employee.
CREATE PROCEDURE Log_Hours
	@ProjectID INT, @EmployeeID INT, @Description NVARCHAR(500), @Date DATE, @Hours INT
AS 
BEGIN
	INSERT INTO Production.ProjectHours
	(ProjectID, EmployeeID, [Description], WorkPerformedDate, [Hours])

VALUES (@ProjectID, @EmployeeID, @Description, @Date, @Hours)
END;	
GO

EXEC Log_Hours
    @ProjectID = 50,
    @EmployeeID = 3,
    @Description = 'Working Hard',
    @Date = '2025-01-01',
    @Hours = 9;

SELECT * FROM Production.ProjectHours

--Update a time entry
--Demonstrates: UPDATE with identity key.
CREATE PROCEDURE Update_Time_Entry
	@ProjectHoursID INT, @Hours INT, @Description NVARCHAR(500)
AS 
BEGIN 
	UPDATE Production.ProjectHours
	SET [Hours] = @Hours, [Description] = @Description, WorkPerformedDate = GETDATE() 
	WHERE ProjectHoursID = @ProjectHoursID
END;	
GO

EXEC Update_Time_Entry
	@ProjectHoursID = 50,
	@Hours = 20,
	@Description = 'Still at it G'; 

--Get total hours per project
--Demonstrates: aggregation, grouping, joins.
CREATE PROCEDURE Get_Total_Hours_Per_Project
	@ProjectID INT
AS 
BEGIN
SELECT PH.ProjectID, SUM(PH.Hours) AS ProjectHours, P.ProjectID, C.FirstName, C.LastName, P.ProjectName
FROM Production.ProjectHours PH
	JOIN Production.Project P ON PH.ProjectID = P.ProjectID
	LEFT JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
WHERE PH.ProjectID = @ProjectID
GROUP BY PH.ProjectID, P.ProjectID,C.FirstName, C.LastName,P.ProjectName
END;
GO

EXEC Get_Total_Hours_Per_Project
	@ProjectID = 2

SELECT * FROM Production.ProjectHours