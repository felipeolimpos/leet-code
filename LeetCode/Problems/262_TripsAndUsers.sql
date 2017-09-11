SELECT
    Request_at as Day,
    ROUND(
            SUM(CASE WHEN Status <> 'completed' THEN 1 ELSE 0 END) 
            / 
            COUNT(*)
          , 2) as 'Cancellation Rate'
FROM Trips
INNER JOIN Users ON Client_Id = Users_Id AND Banned = 'No'
WHERE Request_at BETWEEN '2013-10-01' AND '2013-10-03'
GROUP BY Request_at