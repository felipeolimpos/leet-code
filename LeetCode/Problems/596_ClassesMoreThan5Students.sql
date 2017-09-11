SELECT c.class
FROM (
    SELECT distinct class, student
    FROM courses
) as c
GROUP BY c.class
HAVING COUNT(*) >= 5