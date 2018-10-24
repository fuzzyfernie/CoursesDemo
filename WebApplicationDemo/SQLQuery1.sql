Select StudentFName, StudentLName, ClassName, convert(varchar,ClassTime ,108)
From Student 
Join Student_Schedule On Student_Schedule.StudentID = Student.StudentID
Join Classes_Available On Classes_Available.ClassID = Student_Schedule.ClassID