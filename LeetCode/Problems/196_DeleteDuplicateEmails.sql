DELETE p FROM Person p
WHERE NOT EXISTS (
    SELECT 1
    FROM (
        SELECT MIN(Id) as Id 
        FROM Person 
        GROUP BY Email
    ) p2
    WHERE p.Id = p2.Id
);