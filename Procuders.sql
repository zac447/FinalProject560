--Customer Procedures

--Add new customer. 
--INSERT, strings + ints, identity key.
CREATE PROCEDURE Add_Customer
	@Email NVARCHAR(50), @LastName NVARCHAR(30), @FirstName NVARCHAR(30), @Phone NVARCHAR(10), 
	@Address NVARCHAR(60), @City NVARCHAR(20), @State NVARCHAR(20), @ZipCode NVARCHAR(5), @Status NVARCHAR(10)
AS 
BEGIN
	INSERT INTO Sales.Customer 
	(Email, LastName, FirstName, Phone, [Address], City, [State], ZipCode, [Status])

VALUES (@Email, @LastName, @FirstName, @Phone, @Address, @City, @State, @ZipCode, @Status)
END;	
GO

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
--UPDATE, use of primary key.
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
--soft delete requirement.
CREATE PROCEDURE Deactivate_Customer --didnt use implemented with update customer
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
--searching/listing records.
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
--INSERT, strings + ints, identity key.
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
--UPDATE, use of primary key.
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
	@ManagerID = 3,
    @LastName = 'Atchison',
    @FirstName = 'Zac',
    @DateOfBirth = '2004-01-01',
    @Title = 'A Big Dawg',
    @Status = 'Active',
    @HourlyRate = 40.00;

SELECT * FROM HR.Employee


--Soft-delete employee
--soft delete requirement.
CREATE PROCEDURE Deactivate_Employee --didnt use implemented with update employee
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
--searching/listing records.
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
--INSERT into a table with FK to Sales.Customer.
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
--business state changes with UPDATE.
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

--Search Proposals
CREATE PROCEDURE List_Proposal_By_Status_OR_Customer
    @CustomerID INT = NULL, 
    @Status NVARCHAR(10) = NULL
AS 
BEGIN
    SELECT 
        C.CustomerID, 
        PP.ProjectProposalID,
        PP.ProjectName, 
        PP.ProjectDetails,
        PP.EstimatedDurationHours,  
        PP.Status,
        C.FirstName + ' ' + C.LastName AS FullName
    FROM Sales.ProjectProposal PP 
        JOIN Sales.Customer C ON PP.CustomerID = C.CustomerID
    WHERE (@CustomerID IS NULL OR C.CustomerID = @CustomerID) 
       AND (@Status IS NULL OR PP.Status = @Status)
    ORDER BY PP.Status, C.LastName ASC, C.FirstName ASC
END;
GO

EXEC List_Proposal_By_Status_OR_Customer
	
	@Status = Proposed;

SELECT * FROM Sales.ProjectProposal


--Project Procedures

--Create project from an approved proposal
--INSERT based on another table, JOIN/SELECT inside procedure, foreign keys working.

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
--UPDATE, date handling.
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

--Searchs projects
CREATE PROCEDURE Search_Projects
    @CustomerName NVARCHAR(80) = NULL,
    @ManagerID INT = NULL,
    @Status NVARCHAR(10) = NULL
AS 
BEGIN
    SELECT 
        P.ProjectID,                                  
        P.CustomerID,                                          
        P.ProjectName,
        P.StartDate,
        P.EndDate,
        P.ManagerID,                                           
        P.[Status],
        C.FirstName + ' ' + C.LastName AS FullCustomerName, 
        C.Address + ' ' + C.City + ' ' + C.State AS FullCustomerAddress,
        C.ZipCode,
        E.FirstName + ' ' + E.LastName AS Manager          
    FROM Production.Project P 
        JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
        JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
    WHERE (@CustomerName IS NULL OR C.FirstName = @CustomerName) 
       AND (@ManagerID IS NULL OR E.EmployeeID = @ManagerID) 
       AND (@Status IS NULL OR P.Status = @Status)
    ORDER BY FullCustomerName ASC, P.ProjectName ASC
END;

EXEC Search_Projects
	@Status = InProgress;

--Project Hours Procedures

--Log hours worked on a project
--INSERT with FK to Project and Employee.
CREATE PROCEDURE Log_Hours --Didnt use
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
--UPDATE with identity key.
CREATE PROCEDURE Update_Time_Entry --didnt use
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

--Aggregating queries

--Get total hours per project
--Gets the total hours completed hours on a project for company reference to see how it compares to how many hours they thought the project was going to take.
CREATE PROCEDURE Get_Total_Hours_Per_Project 
	@ProjectID INT
AS 
BEGIN
SELECT PH.ProjectID, SUM(PH.Hours) AS ProjectHours, C.FirstName, C.LastName, P.ProjectName
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


--Query 3
--Created to see how many sales each employee has done within a certain time span.
CREATE PROCEDURE MonthlySalesByEmployee --done
    @StartDate DATE = NULL,
    @EndDate   DATE = NULL
AS
BEGIN
	WITH CTE AS (
	SELECT PH.EmployeeID, PH.WorkPerformedDate,
        PH.[Hours],
        PRT.HourlyRate
    FROM Production.ProjectHours PH
    JOIN Production.ProjectRateType PRT
        ON PH.ProjectID = PRT.ProjectID
       AND PH.WorkPerformedDate >= PRT.StartDate
       AND (PRT.EndDate IS NULL OR PH.WorkPerformedDate <= PRT.EndDate)
	), Aggregated AS
	(
    SELECT
        YEAR(CTE.WorkPerformedDate)  AS WorkYear, MONTH(CTE.WorkPerformedDate) AS WorkMonth, E.EmployeeID,
        E.FirstName + ' ' + E.LastName AS EmployeeName,
        SUM(CTE.[Hours])                AS TotalHours,
        SUM(CTE.[Hours] * CTE.HourlyRate) AS TotalSales
    FROM CTE 
    JOIN HR.Employee E
        ON CTE.EmployeeID = E.EmployeeID
    GROUP BY
        YEAR(CTE.WorkPerformedDate),
        MONTH(CTE.WorkPerformedDate),
        E.EmployeeID,
        E.FirstName,
        E.LastName
	)
    SELECT WorkYear, WorkMonth, EmployeeID, EmployeeName, TotalHours, TotalSales,
    DENSE_RANK() OVER ( PARTITION BY WorkYear, WorkMonth ORDER BY TotalSales DESC
    ) AS SalesRankInMonth
FROM Aggregated
ORDER BY WorkYear, WorkMonth, SalesRankInMonth, EmployeeName;
END;
GO

EXEC MonthlySalesByEmployee @StartDate = '2024-01-01', @EndDate = '2024-12-31';

--Query 4
CREATE PROCEDURE ManagerApprovedProjects --didnt use
    @ManagerID INT = NULL, @Status NVARCHAR(10) = NULL   
AS
BEGIN
    IF @Status IS NULL
        SET @Status = 'Completed';
    SELECT
        E.EmployeeID AS ManagerID, E.FirstName + ' ' + E.LastName AS ManagerName, P.ProjectID, P.ProjectName, C.CustomerID,
        C.FirstName + ' ' + C.LastName AS CustomerName, P.[Status], P.StartDate, P.EndDate
    FROM Production.Project P
    JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
    JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
    WHERE P.[Status] = @Status AND (@ManagerID IS NULL OR P.ManagerID = @ManagerID)
    ORDER BY ManagerName, P.ProjectName;
END;
GO

EXEC ManagerApprovedProjects @Status = 'InProgress'

--Gets total cost of the project not including along with the hours that has been worked on the project.
CREATE PROCEDURE GetProjectCostSummary
    @ProjectID INT = NULL,
    @Status NVARCHAR(10) = NULL
AS
BEGIN
    SELECT 
        P.ProjectID,
        P.ProjectName,
        P.[Status],
        C.FirstName + ' ' + C.LastName AS CustomerName,
        E.FirstName + ' ' + E.LastName AS ManagerName,
        
        -- materials
        SUM(ISNULL(PM.Total, 0)) AS TotalMaterialCost,
        
        -- hours
        SUM(ISNULL(PH.[Hours], 0)) AS TotalLaborHours,
        AVG(ISNULL(PRT.HourlyRate, 0)) AS AvgHourlyRate,
        SUM(ISNULL(PH.[Hours], 0) * ISNULL(PRT.HourlyRate, 0)) AS TotalLaborCost,
        
        -- overall cost
        SUM(ISNULL(PM.Total, 0)) + 
        SUM(ISNULL(PH.[Hours], 0) * ISNULL(PRT.HourlyRate, 0)) AS TotalProjectCost,
        
        P.StartDate,
        P.EndDate
        
    FROM Production.Project P
    JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
    JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
    LEFT JOIN Production.ProjectMaterials PM ON P.ProjectID = PM.ProjectID
    LEFT JOIN Production.ProjectHours PH ON P.ProjectID = PH.ProjectID
    LEFT JOIN Production.ProjectRateType PRT 
        ON P.ProjectID = PRT.ProjectID
        AND PH.WorkPerformedDate >= PRT.StartDate
        AND (PRT.EndDate IS NULL OR PH.WorkPerformedDate <= PRT.EndDate)
    
    WHERE (@ProjectID IS NULL OR P.ProjectID = @ProjectID)
      AND (@Status IS NULL OR P.[Status] = @Status)
    
    GROUP BY P.ProjectID, P.ProjectName, P.[Status], C.FirstName, C.LastName, E.FirstName, E.LastName, P.StartDate, P.EndDate
    
    ORDER BY TotalProjectCost DESC, P.ProjectName;
END;
GO

-- example executions

-- get all project costs
EXEC GetProjectCostSummary;

-- get specific project cost
EXEC GetProjectCostSummary @ProjectID = 1;

-- get costs for completed projects only
EXEC GetProjectCostSummary @Status = 'Completed';

-- get costs for in progress projects only
EXEC GetProjectCostSummary @Status = 'InProgress';


--Finds the total cost of materials that have been used on the project. Again helps to see what was actually spent compared to what was expected to spend.
CREATE PROCEDURE GetProjectMaterialCostSummary
    @ProjectID INT = NULL,
    @Status NVARCHAR(10) = NULL
AS
BEGIN
    SELECT 
        P.ProjectID,
        P.ProjectName,
        P.[Status],
        C.FirstName + ' ' + C.LastName AS CustomerName,
        E.FirstName + ' ' + E.LastName AS ManagerName,
        COUNT(PM.MaterialID) AS MaterialCount,
        SUM(ISNULL(PM.Total, 0)) AS TotalMaterialCost,
        P.StartDate,
        P.EndDate
    FROM Production.Project P
    JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
    JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
    LEFT JOIN Production.ProjectMaterials PM ON P.ProjectID = PM.ProjectID
    WHERE (@ProjectID IS NULL OR P.ProjectID = @ProjectID)
      AND (@Status IS NULL OR P.[Status] = @Status)
    GROUP BY P.ProjectID, P.ProjectName, P.[Status], C.FirstName, C.LastName, E.FirstName, E.LastName, P.StartDate, P.EndDate
    ORDER BY TotalMaterialCost DESC, P.ProjectName;
END;
GO

--examples
EXEC GetProjectMaterialCostSummary;
EXEC GetProjectMaterialCostSummary @ProjectID = 1;
EXEC GetProjectMaterialCostSummary @Status = 'Completed';