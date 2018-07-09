SELECT CASE
         WHEN ((A + B > C) AND (A + C > B) AND (B + C > A)) AND (A = B AND B = C)
           THEN 'Equilateral'
         WHEN ((A + B > C) AND (A + C > B) AND (B + C > A)) AND (A <> B AND B <> C AND A <> C)
          THEN 'Scalene'
         WHEN ((A + B > C) AND (A + C > B) AND (B + C > A))
           THEN 'Isosceles'
         ELSE 'Not A Triangle'
       END
  FROM TRIANGLES
;
