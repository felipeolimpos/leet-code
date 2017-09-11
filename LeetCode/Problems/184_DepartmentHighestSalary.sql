SELECT
    d.Name as Department,
    e.Name as Employee,
    e.Salary as Salary
FROM Department d
INNER JOIN Employee e ON d.Id = e.DepartmentId
WHERE
    (d.Id, e.Salary) in 
    (
        SELECT e1.DepartmentId, max(e1.Salary)
        FROM Employee e1
        GROUP BY e1.DepartmentId
    )
ORDER BY e.Salary;