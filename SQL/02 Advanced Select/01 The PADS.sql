SELECT Name + '(' + LEFT(Occupation, 1) + ')' AS myOcupations
  FROM OCCUPATIONS
 ORDER BY Name
 ;


SELECT 'There are a total of ' + CONVERT(varchar(10),COUNT(*)) + ' ' + LOWER(Occupation) + 's.' AS myOcupations
  FROM OCCUPATIONS
 GROUP BY Occupation
 ORDER BY myOcupations ASC
 ;
