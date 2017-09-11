SELECT
    w.id
FROM
    weather w
INNER JOIN weather w1 
WHERE 
    DATEDIFF(w.date, w1.date) = 1
    AND 
    w.Temperature > w1.Temperature;