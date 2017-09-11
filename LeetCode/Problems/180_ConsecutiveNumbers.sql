SELECT DISTINCT
    l.Num AS ConsecutiveNums
FROM Logs l
INNER JOIN Logs l1
ON l1.Id = (l.Id + 1)
INNER JOIN Logs l2
ON l2.Id = (l.Id + 2)
WHERE
    l.Num = l1.Num
    AND 
    l.Num = l2.Num;