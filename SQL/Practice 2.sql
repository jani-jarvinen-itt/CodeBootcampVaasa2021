-- Day 9, Practice 2.1
SELECT COUNT(CustomerID)
FROM Customers

-- Practice 2.2
SELECT SUM(UnitPrice*UnitsInStock) AS 'Value in $'
FROM Products

-- Practice 2.3, without discounts
SELECT SUM(UnitPrice*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID = 14

-- Practice 2.3, with discount
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID = 14

-- Practice 2.3, with discount and "Longlife Tofu"
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

-- Practice 2.3, with discount and "Longlife Tofu", as subquery
SELECT SUM((UnitPrice*(1-Discount))*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID IN (
	SELECT ProductID
	FROM Products
	WHERE ProductName LIKE '%Tofu%')
