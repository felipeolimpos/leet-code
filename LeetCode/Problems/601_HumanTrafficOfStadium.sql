SELECT DISTINCT s.id, s.date, s.people
FROM stadium s
INNER JOIN (
    SELECT s1.id as id1, s2.id as id2, s3.id as id3
    FROM stadium s1
    INNER JOIN stadium s2 ON s2.id = (s1.id + 1)
    INNER JOIN stadium s3 ON s3.id = (s1.id + 2)
    WHERE 
        s1.people >= 100
        AND
        s2.people >= 100
        AND
        s3.people >= 100
) ids ON (s.id = ids.id1 OR s.id = ids.id2 OR s.id = ids.id3)