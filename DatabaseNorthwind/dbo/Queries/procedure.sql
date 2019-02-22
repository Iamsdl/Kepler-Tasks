CREATE PROCEDURE SalesByTerritory AS
	SELECT Territories.TerritoryDescription, convert(decimal(10,2), SUM([Order Details].UnitPrice*[Order Details].Quantity*(1-[Order Details].Discount))) as Total
	FROM Territories
	LEFT JOIN EmployeeTerritories ON EmployeeTerritories.TerritoryID=Territories.TerritoryID
	LEFT JOIN Employees ON Employees.EmployeeID=EmployeeTerritories.EmployeeID
	LEFT JOIN Orders ON Orders.EmployeeID=Employees.EmployeeID
	LEFT JOIN [Order Details] ON [Order Details].OrderID=Orders.OrderID
	GROUP BY TerritoryDescription
	order by TerritoryDescription

exec SalesByTerritory
