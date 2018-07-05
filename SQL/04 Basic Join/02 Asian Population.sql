SELECT SUM(POPULATION)
  FROM CITY
 WHERE COUNTRYCODE in (
                      SELECT CODE
                        FROM COUNTRY
                       WHERE CONTINENT = 'Asia'
                      )
;
