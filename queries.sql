CREATE TABLE Cohort (
		CohortId			INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
		CohortName  TEXT NOT NULL
);

CREATE TABLE Student (
		StudentId		INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
		FirstName		TEXT NOT NULL,
		LastName		TEXT NOT NULL,
		SlackHandle	TEXT NOT NULL,
		CohortId			INTEGER NOT NULL,
		FOREIGN KEY (CohortId) REFERENCES Cohort(CohortId)
);

CREATE TABLE Instructor (
		InstructorId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
		FirstName		TEXT NOT NULL,
		LastName		TEXT NOT NULL,
		SlackHandle	TEXT NOT NULL,
		CohortId			INTEGER NOT NULL,
		FOREIGN KEY (CohortId) REFERENCES Cohort(CohortId)
);

CREATE TABLE Exercise (
		ExerciseId					INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
		Name							TEXT NOT NULL,
		ExerciseLanguage		TEXT NOT NULL
);

CREATE TABLE StudentExercise (
		StudentExerciseId	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
		StudentId				INTEGER NOT NULL,
		ExerciseId				INTEGER NOT NULL,
		FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
		FOREIGN KEY (ExerciseId) REFERENCES Exercise(ExerciseId)
);

INSERT INTO Cohort
(CohortName)
VALUES 
("Day Cohort 26")
;

INSERT INTO Cohort
(CohortName)
VALUES 
("Day Cohort 27")
;

INSERT INTO Cohort
(CohortName)
VALUES 
("Day Cohort 28")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Wizard of Oz HTML practice", "HTML and CSS")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Chicken Monkey", "JavaScript")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Fizz Buzz", "JavaScript")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Loops Practice", "JavaScript")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Array Method Practice", "JavaScript")
;

INSERT INTO Exercise 
(Name, ExerciseLanguage)
VALUES 
("N.S.S.I.A.", "JavaScript")
;

INSERT INTO Exercise 
(Name, ExerciseLanguage)
VALUES 
("Daily Journal", "JaveScript")
;

INSERT INTO Exercise 
(Name, ExerciseLanguage)
VALUES 
("Nutshell JS", "JavaScript")
;

INSERT INTO Exercise 
(Name, ExerciseLanguage)
VALUES 
("Kennel React", "React.js")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Nutshell React", "React.js")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("C# List Practice", "C#")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Try and Catch Practice", "C#")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Student Tracker", "C#")
;

INSERT INTO Exercise
(Name, ExerciseLanguage)
VALUES 
("Final CapStone", "C#")
;

INSERT INTO Instructor
SELECT NULL, "Steve", "Brownlee", "@coach", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Instructor
SELECT NULL, "Meg", "Ducharme", "@megducharme", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Instructor
SELECT NULL, "Kimmy", "Bird", "@kimmy", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Instructor
SELECT NULL, "Andy", "Collins", "@andyc", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Instructor
SELECT NULL, "Jenna", "Solis", "@jenna", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 28"
;

INSERT INTO Instructor
SELECT NULL, "Emily", "Lemon", "@emlem", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;

INSERT INTO Student
SELECT NULL, "Ricky", "Bruner", "@Ricky Bruner", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Student
SELECT NULL, "Kayla", "Reid", "@Kayla Reid", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Student
SELECT NULL, "Helen", "Chalmers", "@Helen Chalmers", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Student
SELECT NULL, "Alejandro", "Font", "@Alejandro Font", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Student
SELECT NULL, "Dejan", "SomethingCrazy", "@Dejan SomethingCrazy", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 27"
;

INSERT INTO Student
SELECT NULL, "Kelly", "Morin", "@Kelly Morin", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 28"
;

INSERT INTO Student
SELECT NULL, "Sebastian", "Civarolo", "@sebastian", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 28"
;

INSERT INTO Student
SELECT NULL, "William", "Kimball", "@William Kimball", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;

INSERT INTO Student
SELECT NULL, "Brett", "Shearin", "@Brett Shearin", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;

INSERT INTO Student
SELECT NULL, "Jordan", "Williams", "@Jordan Williams", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;

INSERT INTO Student
SELECT NULL, "Jenn", "Lawson", "@Jenn Lawson", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;

INSERT INTO Student
SELECT NULL, "Austin", "Gorman", "@Austin Gorman", Cohort.CohortId
FROM Cohort
WHERE Cohort.CohortName = "Day Cohort 26"
;


INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Ricky"
AND e.Name = "Student Tracker"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Ricky"
AND e.Name = "C# List Practice"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Kayla"
AND e.Name = "Student Tracker"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Kayla"
AND e.Name = "C# List Practice"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Helen"
AND e.Name = "Nutshell React"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Helen"
AND e.Name = "Student Tracker"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Dejan"
AND e.Name = "Nutshell JS"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Dejan"
AND e.Name = "Student Tracker"
;
         
INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Alejandro"
AND e.Name = "Student Tracker"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Alejandro"
AND e.Name = "Kennel React"
;		 
            
INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Kelly"
AND e.Name = "N.S.S.I.A."
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Kelly"
AND e.Name = "Wizard of Oz HTML practice"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Sebastian"
AND e.Name = "Wizard of Oz HTML practice"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Sebastian"
AND e.Name = "N.S.S.I.A."
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "William"
AND e.Name = "Final CapStone"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Austin"
AND e.Name = "Final CapStone"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Jordan"
AND e.Name = "Final CapStone"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Jenn"
AND e.Name = "Final CapStone"
;

INSERT INTO StudentExercise
SELECT NULL, s.StudentId, e.ExerciseId
FROM Student s, Exercise e
WHERE s.FirstName = "Brett"
AND e.Name = "Final CapStone"
;



