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

