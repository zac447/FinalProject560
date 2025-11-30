--current projects by customer
CREATE VIEW CustomerActiveProjectsView
AS
SELECT C.CustomerID, C.FirstName + ' ' + C.LastName AS CustomerName, C.Phone, P.ProjectID, P.ProjectName, PP.ProjectDetails, P.Status, P.StartDate, P.EndDate
FROM Sales.Customer C
	JOIN Production.Project P ON C.CustomerID = P.CustomerID
	JOIN Sales.ProjectProposal PP ON P.ProjectID = PP.ProjectProposalID
	JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
WHERE P.Status = 'InProgress'


  SELECT * FROM CustomerActiveProjectsView WHERE CustomerID = 1;

  SELECT * FROM Production.Project

--Sales/Estimates screen
CREATE VIEW ProposalPipeline
AS
SELECT C.CustomerID, C.FirstName + ' ' + C.LastName AS CustomerName, C.Phone, PP.ProjectName, PP.ProjectDetails, PP.EstimatedDurationHours, PP.Status
FROM Sales.Customer C
	JOIN Sales.ProjectProposal PP ON C.CustomerID = PP.CustomerID
WHERE PP.Status = 'Proposed'

  SELECT * FROM ProposalPipeline WHERE CustomerID = 1;

  SELECT * FROM Production.Project

 --Show all relationships
CREATE VIEW ProjectCostSummary
AS
SELECT P.ProjectID, P.ProjectName, C.CustomerID, C.FirstName + ' ' + C.LastName AS Customer , E.FirstName + ' ' + E.LastName AS ProjectManager,
	SUM(ISNULL(PM.Total, 0)) AS TotalMaterialCost, SUM(ISNULL(PH.Hours, 0)) AS TotalHours, PRT.HourlyRate,
	SUM(ISNULL(PH.[Hours], 0)) * PRT.HourlyRate AS LaborCost,
	SUM(ISNULL(PM.Total, 0)) + SUM(ISNULL(PH.[Hours], 0)) * PRT.HourlyRate AS OverallCost
FROM Production.Project P
	LEFT JOIN Production.ProjectMaterials PM ON P.ProjectID = PM.ProjectID
	LEFT JOIN Production.ProjectHours PH ON PM.ProjectID = PH.ProjectID
	LEFT JOIN Production.ProjectRateType PRT ON PH.ProjectID = PRT.ProjectID
	JOIN Sales.Customer C ON P.CustomerID = C.CustomerID
	JOIN HR.Employee E ON P.ManagerID = E.EmployeeID
GROUP BY
    P.ProjectID,
    P.ProjectName,
    C.CustomerID,
    C.FirstName + ' ' + C.LastName,
    E.FirstName + ' ' + E.LastName,
    PRT.HourlyRate;

SELECT * FROM ProjectCostSummary WHERE CustomerID = 1;

SELECT * FROM Production.ProjectMaterials
