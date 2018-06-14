SELECT Hackers.hacker_id, name, TotalScore
  FROM (
        SELECT hacker_id, SUM(MaxsScore) AS TotalScore
          FROM (
                SELECT hacker_id, challenge_id, MAX(score) as MaxsScore
                  FROM Submissions
                 GROUP BY hacker_id, challenge_id
              ) MaxScores
         GROUP BY hacker_id
       ) TotalScores
  LEFT JOIN  Hackers
    ON TotalScores.hacker_id = Hackers.hacker_id
 WHERE TotalScore > 0
 ORDER BY TotalScore DESC, hacker_id ASC
;
