
SELECT DISTINCT Country FROM Customers;

SELECT COUNT(DISTINCT Country) FROM Customers;

SELECT * FROM Customers
WHERE Country='Mexico';

SELECT * FROM Customers
WHERE Country='Germany' AND City='Berlin';

SELECT * FROM Customers
WHERE City='Berlin' OR City='München';

SELECT * FROM Customers
WHERE NOT Country='Germany';

SELECT * FROM Customers
WHERE Country='Germany' AND (City='Berlin' OR City='München');

SELECT * FROM Customers
ORDER BY Country DESC;

SELECT * FROM Customers
ORDER BY Country, CompanyName;

SELECT * FROM Customers
ORDER BY Country ASC, CompanyName DESC;

INSERT INTO Customers (CompanyName, City, Country)
VALUES ('Cardinal', 'Stavanger', 'Norway');

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 'ALFKI';

UPDATE Customers
SET ContactName='Juan'
WHERE Country='Mexico';

DELETE FROM Customers
WHERE CompanyName='Alfreds Futterkiste';

SELECT TOP 3 * FROM Customers;

SELECT TOP 50 PERCENT * FROM Customers;

SELECT TOP 3 * FROM Customers
WHERE Country='Germany';

SELECT MIN(UnitPrice) AS SmallestPrice
FROM Products;

SELECT MAX(UnitPrice) AS LargestPrice
FROM Products;

SELECT COUNT(ProductID)
FROM Products;

SELECT AVG(UnitPrice)
FROM Products;

SELECT SUM(Quantity)
FROM [Order Details];

SELECT * FROM Customers
WHERE CompanyName LIKE 'a%';

SELECT * FROM Customers
WHERE CompanyName LIKE '%a';

SELECT * FROM Customers
WHERE CompanyName LIKE '%or%';

SELECT * FROM Customers
WHERE CompanyName LIKE '_r%';

SELECT * FROM Customers
WHERE CompanyName LIKE 'a_%_%';

SELECT * FROM Customers
WHERE ContactName LIKE 'a%o';

SELECT * FROM Customers
WHERE CompanyName NOT LIKE 'a%';

SELECT * FROM Customers
WHERE City LIKE '[bsp]%';

SELECT * FROM Customers
WHERE City LIKE '[a-c]%';

SELECT * FROM Customers
WHERE City LIKE '[!bsp]%';

SELECT * FROM Customers
WHERE City NOT LIKE '[bsp]%';

SELECT * FROM Customers
WHERE Country IN ('Germany', 'France', 'UK');

SELECT * FROM Customers
WHERE Country NOT IN ('Germany', 'France', 'UK');

SELECT * FROM Customers
WHERE Country IN (SELECT Country FROM Suppliers);

SELECT * FROM Products
WHERE UnitPrice BETWEEN 10 AND 20;

SELECT * FROM Products
WHERE (UnitPrice BETWEEN 10 AND 20)
AND NOT CategoryID IN (1,2,3);

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

SELECT * FROM Products
WHERE ProductName NOT BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

SELECT * FROM Orders
WHERE OrderDate BETWEEN '07/04/1996' AND '07/09/1996';

SELECT CustomerID as ID, CompanyName AS Customer
FROM Customers;

SELECT CompanyName AS Customer, ContactName AS [Contact Person]
FROM Customers;

SELECT CompanyName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address
FROM Customers;

SELECT o.OrderID, o.OrderDate, c.CompanyName
FROM Customers AS c, Orders AS o
WHERE c.CompanyName='Around the Horn' AND c.CustomerID=o.CustomerID;

SELECT Orders.OrderID, Orders.OrderDate, Customers.CompanyName
FROM Customers, Orders
WHERE Customers.CompanyName='Around the Horn' AND Customers.CustomerID=Orders.CustomerID;

SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

SELECT Orders.OrderID, Customers.CompanyName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

SELECT Customers.CompanyName, Orders.OrderID
FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.CompanyName;

SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

SELECT Customers.CompanyName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CompanyName;

SELECT A.CompanyName AS CompanyName1, B.CompanyName AS CompanyName2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City 
ORDER BY A.City;

SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

SELECT City FROM Customers
UNION ALL
SELECT City FROM Suppliers
ORDER BY City;

SELECT City, Country FROM Customers
WHERE Country='Germany'
UNION 
SELECT City, Country FROM Suppliers
WHERE Country='Germany'
ORDER BY City;

SELECT 'Customer' As Type, ContactName, City, Country
FROM Customers
UNION
SELECT 'Supplier', ContactName, City, Country
FROM Suppliers;

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country;

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY CompanyName;

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;

SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 1
ORDER BY COUNT(CustomerID) DESC;

SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM (Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 70;

SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
WHERE LastName = 'Davolio' OR LastName = 'Fuller'
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 25;

SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE SupplierId = Suppliers.supplierId AND UnitPrice < 60);

SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE SupplierId = Suppliers.supplierId AND UnitPrice = 22);

SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity = 20);

SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity > 99);

SELECT ProductName
FROM Products
WHERE ProductID = ALL (SELECT ProductID FROM [Order Details] WHERE Quantity = 10);

INSERT INTO Customers (CustomerID,CompanyName, City, Country)
SELECT Supplierid,CompanyName, City, Country FROM Suppliers;

SELECT *
FROM Customers;

SELECT * FROM [Current Product List];

SELECT * FROM [Products Above Average Price];

SELECT * FROM [Category Sales For 1997];

SELECT COUNT(Employees.EmployeeID) as Numar,Territories.TerritoryDescription, Region.RegionDescription
FROM Region
inner join Territories on Territories.RegionID=Region.RegionID 
inner join EmployeeTerritories on Territories.TerritoryID=EmployeeTerritories.TerritoryID
inner join Employees on EmployeeTerritories.EmployeeID=Employees.EmployeeID
group by Region.RegionDescription,Territories.TerritoryDescription
order by Numar desc
