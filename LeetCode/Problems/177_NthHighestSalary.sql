CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
    DECLARE SALARY_INDEX INT;
    SET SALARY_INDEX=N-1;

    RETURN (
        # Write your MySQL query statement below.
        SELECT DISTINCT Salary 
        FROM Employee 
        ORDER BY Salary DESC 
        LIMIT SALARY_INDEX, 1
    );
END