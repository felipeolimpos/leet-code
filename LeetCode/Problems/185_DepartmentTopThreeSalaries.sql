SELECT
    d.Name as Department,
    e.Name as Employee,
    e.Salary as Salary
FROM Employee e
INNER JOIN Department d ON e.DepartmentId = d.Id
WHERE (
    SELECT count(*)
    FROM 
    (
        SELECT DISTINCT 
            emp.DepartmentId,
            emp.Salary
        FROM Employee emp
    ) e1
    WHERE e1.DepartmentId = e.DepartmentId
    AND e1.Salary >= e.Salary
) <= 3
ORDER BY d.Name, e.Salary DESC