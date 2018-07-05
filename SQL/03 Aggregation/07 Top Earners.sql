SELECT CONVERT(varchar(10), MaxEarnings ) + '  ' + COUNT(*)
  FROM (
        SELECT MaxEarnings
          FROM (
                SELECT months * salary AS Earnings
                  FROM Employee
               ) Earnings
          LEFT JOIN (
                    SELECT MAX(months * salary) AS MaxEarnings
                      FROM Employee
                    ) A
            ON Earnings.Earnings = A.MaxEarnings
        ) B
  GROUP BY MaxEarnings
 HAVING  MaxEarnings IS NOT NULL
;
