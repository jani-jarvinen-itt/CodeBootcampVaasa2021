-- Day 9, Practice 1.1
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Practice 1.2
SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'

-- Practice 1.2, alternative implementation
SELECT *
FROM Orders
WHERE CustomerID = (
	SELECT CustomerID
	FROM Customers
	WHERE CompanyName = 'Que Delícia'
)

-- Practice 1.3
SELECT *
FROM Employees
WHERE City = 'London' AND Country = 'UK'
