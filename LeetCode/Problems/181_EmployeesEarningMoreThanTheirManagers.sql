SELECT e.Name as Employee
FROM Employee e
INNER JOIN Employee m ON m.Id = e.ManagerId
WHERE e.Salary > m.Salary;