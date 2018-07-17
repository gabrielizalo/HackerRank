SELECT [Doctor], [Professor], [Singer], [Actor]
  FROM (
       SELECT ROW_NUMBER() OVER ( PARTITION BY OCCUPATION ORDER BY NAME ) [RowNumber], *
         FROM OCCUPATIONS
       ) AS SourceTable
  PIVOT
     ( MAX(NAME)
       FOR OCCUPATION
        IN ([Doctor], [Professor], [Singer], [Actor])
     ) AS pivotTable
;


/*


select * , row_number() over(partition by occupation order by name) as RN
from occupations


SELECT
  Max(Case Occupation When 'Doctor' Then Name End) Doctor,
  Max(Case Occupation When 'Professor' Then Name End) Professor,
  Max(Case Occupation When 'Singer' Then Name End) Singer,
  Max(Case Occupation When 'Actor' Then Name End) Actor
  FROM OCCUPATIONS
 GROUP BY Name
;


SELECT [Doctor], [Professor], [Singer], [Actor]
FROM
  (
  SELECT Name, Occupation
    FROM OCCUPATIONS
  ) AS SourceTable
  PIVOT
  (
    MAX(Name)
    FOR Occupation
    IN ([Doctor], [Professor], [Singer], [Actor])
  ) AS PivotTable
;


*/
