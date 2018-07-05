SELECT CAST(MAX(LONG_W) AS DECIMAL (16,4))
  FROM STATION
 WHERE LAT_N = (
                SELECT MAX(LAT_N) AS LAT_N
                  FROM STATION
                 WHERE LAT_N < 137.2345
               )
;
