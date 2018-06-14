SELECT Name
 FROM (
        SELECT Students.ID, Name, PackagesStudents.Salary AS StudentSalary, Friends.ID AS Friends_ID, PackagesFriends.Salary AS FriendsSalary
          FROM Students
          LEFT JOIN Packages PackagesStudents
            ON Students.ID = PackagesStudents.ID
          LEFT JOIN Friends
            ON Students.ID = Friends.ID
          LEFT JOIN Packages PackagesFriends
            ON Friends.Friend_ID = PackagesFriends.ID
      ) AllInfo
  WHERE StudentSalary < FriendsSalary
  ORDER BY FriendsSalary
;


