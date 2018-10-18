using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();
            cohort26.CohortName = "Day Cohort 26";
            
            Cohort cohort27 = new Cohort();
            cohort27.CohortName = "Day Cohort 27";
            
            Cohort cohort28 = new Cohort();
            cohort28.CohortName = "Day Cohort 28";
            
            Instructor Steve = new Instructor("Steve", "Brownlee", "@coach", cohort27);
            Instructor Meg = new Instructor("Meg", "Ducharme", "@megducharme", cohort27);
            Instructor Kimmy = new Instructor("Kimberly", "Bird", "@kimmy", cohort27);
            Instructor Andy = new Instructor("Andy", "Collins", "@andyc", cohort27);
            Instructor Jenna = new Instructor("Jenna", "Solis", "@jenna", cohort28);
            Instructor Emily = new Instructor("Emily", "Lemmon", "@emlem", cohort26);

            Student Ricky = new Student("Ricky", "Bruner", "@Ricky Bruner", cohort27);
            Student Kayla = new Student("Kayla", "Reid", "@Kayla Reid", cohort27);
            Student Helen = new Student("Helen", "Chalmers", "@Helen Chalmers", cohort27);
            Student Alejandro = new Student("Alejandro", "Font", "@Alejandro Font", cohort27);
            Student Dejan = new Student("Dejan", "SomethingCrazy", "@Dejan SomethingCrazy", cohort27);
            Student Kelly = new Student("Kelly", "Morin", "@Kelly Morin", cohort28);
            Student Sebastian = new Student("Sebastian", "Civarolo", "@sebastian", cohort28);
            Student William = new Student("William", "Kimball", "@William Kimball", cohort26);
            Student Brett = new Student("Brett", "Shearin", "@Brett Shearin", cohort26);
            Student Jordan = new Student("Jordan", "Williams", "@Jordan Williams", cohort26);
            Student Jenn = new Student("Jenn", "Lawson", "@Jenn Lawson", cohort26);
            Student Austin = new Student("Austin", "Gorman", "@Austin Gorman", cohort26);
            Student David = new Student("David", "Taylor", "@David Taylor", cohort27);

            Exercise wizardOfOz = new Exercise(){
                Name = "Wizard of Oz HTML practice",
                ExerciseLanguage = "HTML and CSS"
            };
            
            Exercise chickenMonkey = new Exercise(){
                Name = "Chicken Monkey",
                ExerciseLanguage = "JavaScript"
            };

            Exercise fizzBuzz = new Exercise(){
                Name = "Fizz Buzz",
                ExerciseLanguage = "JavaScript"
            };

            Exercise loops = new Exercise(){
                Name = "Loops Practice",
                ExerciseLanguage = "JavaScript"
            };

            Exercise arrayMethods = new Exercise(){
                Name = "Array Method Practice",
                ExerciseLanguage = "JavaScript"
            };

            Exercise NSSIA = new Exercise(){
                Name = "N.S.S.I.A.",
                ExerciseLanguage = "JavaScript"
            };

            Exercise dailyJournal = new Exercise(){
                Name = "Daily Journal",
                ExerciseLanguage = "JaveScript"
            };

            Exercise nutshellJS = new Exercise(){
                Name = "Nutshell JS",
                ExerciseLanguage = "JavaScript"
            };

            Exercise kennel = new Exercise(){
                Name = "Kennel React",
                ExerciseLanguage = "React.js"
            };

            Exercise nutshellReact = new Exercise(){
                Name = "Nutshell React",
                ExerciseLanguage = "React.js"
            };

            Exercise listPractice = new Exercise(){
                Name = "C# List Practice",
                ExerciseLanguage = "C#"
            };

            Exercise tryCatch = new Exercise(){
                Name = "Try and Catch Practice",
                ExerciseLanguage = "C#"
            };

            Exercise studentTracker = new Exercise(){
                Name = "Student Tracker",
                ExerciseLanguage = "C#"
            };

            Exercise capStone = new Exercise(){
                Name = "Final CapStone",
                ExerciseLanguage = "C#"
            };

            Andy.AssignExercise(Ricky, studentTracker);
            Andy.AssignExercise(Ricky, listPractice);
            Andy.AssignExercise(Ricky, tryCatch);
            Andy.AssignExercise(Kayla, studentTracker);
            Andy.AssignExercise(Kayla, listPractice);
            Meg.AssignExercise(Helen, nutshellReact);
            Meg.AssignExercise(Helen, studentTracker);
            Kimmy.AssignExercise(Dejan, nutshellJS);
            Kimmy.AssignExercise(Dejan, studentTracker);
            Steve.AssignExercise(Alejandro, kennel);
            Steve.AssignExercise(Alejandro, studentTracker);
            Jenna.AssignExercise(Kelly, NSSIA);
            Jenna.AssignExercise(Kelly, wizardOfOz);
            Jenna.AssignExercise(Sebastian, wizardOfOz);
            Jenna.AssignExercise(Sebastian, NSSIA);
            Steve.AssignExercise(William, capStone);
            Steve.AssignExercise(Austin, capStone);
            Steve.AssignExercise(Jordan, capStone);
            Steve.AssignExercise(Jenn, capStone);
            Steve.AssignExercise(Brett, capStone);

            List<Student> students = new List<Student>(){
                Ricky, Kayla, Helen, Alejandro, Dejan, Kelly, Sebastian, William, Brett, Jordan, Jenn, Austin, David
            };

            List<Exercise> exercises = new List<Exercise>(){
                wizardOfOz, fizzBuzz, chickenMonkey, loops, arrayMethods, NSSIA, dailyJournal, nutshellJS, kennel, nutshellReact, listPractice, tryCatch, studentTracker, capStone
            };

            foreach (Student student in students)
            {
                foreach(Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}");
                }
            }

            foreach(Student student in students)
            {
                foreach(Exercise exercise in exercises)
                    {
                        if(student.Exercises.Contains(exercise))
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}");
                        }
                    }
            }

            Console.WriteLine("---------------------------");

            //Begin Student Exercise 2

            // List exercises for the JavaScript ExerciseLanguage by using the Where() LINQ method.
            IEnumerable<Exercise> JSExercises = exercises.Where(e => e.ExerciseLanguage == "JavaScript");
            Console.WriteLine("#1");
            Console.WriteLine("JS Exercises:");
            foreach(Exercise exercise in JSExercises)
            {
                Console.WriteLine(exercise.Name);
            }
            Console.WriteLine("---------------------------");
            
            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<IGrouping<string, Student>> studentsByCohort = students.GroupBy(s => s.Cohort.CohortName);
            foreach(var grouping in studentsByCohort)
            {
                Console.WriteLine(grouping.Key);
                foreach(Student student in grouping)
                {
                    Console.WriteLine(student.FirstName);
                }
            }
            Console.WriteLine("---------------------------");
            
            //Andy's Brain
            IEnumerable<IGrouping<string, Student>> studentsByCohort2 = students.GroupBy(s => s.Cohort.CohortName);
            foreach(var grouping in studentsByCohort2)
            {
                string studentsNames = string.Join(", ", grouping.Select(s => s.FirstName));
                Console.WriteLine($"{grouping.Key}: {studentsNames}");
            }

            // string AndysChallenge = "";
            // foreach(Student student in students)
            // {
            //     if(student.Cohort.Name == "Day Cohort 27")
            //     {
            //         AndysChallenge += student.FirstName + ", ";
            //     }
            // }
            // Console.WriteLine($"Andy's CHallenge: Day Cohort 27: {AndysChallenge}");


            // List instructors in a particular cohort by using the Where() LINQ method.
            Console.WriteLine("---------------------------");

            // Sort the students by their last name.

            List<Student> studentsByLastName = students.OrderBy(s => s.LastName).ToList();
            foreach(Student student in studentsByLastName)
            {
                Console.WriteLine(student.LastName);
            }
            Console.WriteLine("---------------------------");

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)

            List<Student> lameStudents = students.Where(s => s.Exercises.Count == 0).ToList();
            foreach(Student student in lameStudents)
            {
                Console.WriteLine(student.FirstName);
            }

            Console.WriteLine("---------------------------");
            
            
            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

            string overAcheiver = students.OrderByDescending(s => s.Exercises.Count).Take(1).Select(s => s.FirstName).First().ToString();
            Console.WriteLine(overAcheiver);
          
            Console.WriteLine("---------------------------");

            // How many students in each cohort?

            IEnumerable<IGrouping<string, Student>> studentsInCohort = students.GroupBy(s => s.Cohort.CohortName);
            foreach(IGrouping<string, Student> grouping in studentsInCohort)
            {
                Console.WriteLine($"{grouping.Key} has {grouping.Count()} students.");
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("-------------Begin Exercise 4--------------");
            // 1. Add packages for Dapper and Sqlite to your Student Exercises project
            // dotnet add package Dapper
            // dotnet add package Microsoft.Data.Sqlite
            // dotnet restore
                    //DONE
            
            // 2. Create a DatabaseInterface class to interact with your StudentExercises.db database.
                    //DONE

            // 3. Query the database for all the Exercises.

            SqliteConnection db = DatabaseInterface.Connection;

            List<Exercise> queryExercises = db.Query<Exercise>(@"SELECT * FROM Exercise").ToList();

            foreach(Exercise exercise in queryExercises)
            {
                Console.WriteLine($"{exercise.Name}, in {exercise.ExerciseLanguage}.");
            }

            Console.WriteLine("---------------------------");
            // 4. Find all the exercises in the database where the language is JavaScript.

            List<Exercise> JavaScriptExercises = db.Query<Exercise>(@"
                    SELECT * FROM Exercise
                    WHERE Exercise.ExerciseLanguage == 'JavaScript'
            ").ToList();

            foreach(Exercise exercise in JavaScriptExercises)
            {
                Console.WriteLine($"{exercise.Name}, in {exercise.ExerciseLanguage}.");
            }

            Console.WriteLine("---------------------------");
            // Insert a new exercise into the database.

            // db.Execute(@"
            //     INSERT INTO Exercise
            //     (Name, ExerciseLanguage)
            //     VALUES
            //     ('SQL Practice', 'SQLite')
            // ");

            List<Exercise> checkForAddedExercise = db.Query<Exercise>(@"SELECT * FROM Exercise").ToList();

            foreach(Exercise exercise in checkForAddedExercise)
            {
                Console.WriteLine($"{exercise.Name}, in {exercise.ExerciseLanguage}");
            }

            Console.WriteLine("---------------------------");
            // Find all instructors in the database. Include each instructor's cohort.

            List<Instructor> queryInstructors = db.Query<Instructor, Cohort, Instructor>(@"
                SELECT  i.Id,
                        i.FirstName,
                        i.LastName,
                        i.SlackHandle,
                        c.Id,
                        c.CohortName
                FROM Instructor i
                JOIN Cohort c ON c.Id = i.CohortId
            ", (instructor, cohort) => {
                instructor.Cohort = cohort;
                return instructor;
            }).ToList();

            foreach(Instructor instructor in queryInstructors)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}, with the slack handle {instructor.SlackHandle}, is currently teaching in {instructor.Cohort.CohortName}");
            }

            Console.WriteLine("---------------------------");

            // Insert a new instructor into the database. Assign the instructor to an existing cohort.

            // db.Execute(@"
            //     INSERT INTO Instructor
            //     SELECT NULL, 'Jordan', 'Castello', '@Jordan Castello', Cohort.Id
            //     FROM Cohort
            //     WHERE Cohort.CohortName = 'Day Cohort 26'
            // ");

            List<Instructor> newQInstructors = db.Query<Instructor, Cohort, Instructor>(@"
                SELECT  i.Id,
                        i.FirstName,
                        i.LastName,
                        i.SlackHandle,
                        c.Id,
                        c.CohortName
                FROM Instructor i
                JOIN Cohort c ON c.Id = i.CohortId
            ", (instructor, cohort) => {
                instructor.Cohort = cohort;
                return instructor;
            }).ToList();

            foreach(Instructor i in newQInstructors)
            {
                Console.WriteLine($"{i.FirstName}, in {i.Cohort.CohortName}");
            }

            Console.WriteLine("---------------------------");

            // Assign an existing exercise to an existing student.

            // db.Execute(@"
            //     INSERT INTO StudentExercise
            //     SELECT NULL, s.Id, e.Id
            //     FROM Student s, Exercise e
            //     WHERE s.FirstName = 'David'
            //     AND e.Name = 'SQL Practice'
            // ");


            // Challenge - Find all the students in the database. Include each student's cohort AND each student's list of exercises.

            Dictionary<int, Student> sAndE = new Dictionary<int, Student>();

            IEnumerable<Student> completeStudents = db.Query<Student, Cohort, Exercise, Student>(@"
                SELECT  s.Id,
                        s.FirstName,
                        s.LastName,
                        s.SlackHandle,
                        c.Id,
                        c.CohortName,
                        e.Id,
                        e.Name,
                        e.ExerciseLanguage
                FROM Student s
                JOIN Cohort c ON c.Id = s.CohortId
                JOIN StudentExercise se ON se.StudentId = s.Id
                JOIN Exercise e ON se.ExerciseId = e.Id
            ", (student, cohort, exercise) => {
                student.Cohort = cohort;
                if(!sAndE.ContainsKey(student.Id)){
                    sAndE[student.Id] = student;
                }
                sAndE[student.Id].Exercises.Add(exercise);
                return student;
            });

            foreach(KeyValuePair<int, Student> student in sAndE)
            {
                string exerciseList = string.Join(", ", student.Value.Exercises.Select(e => e.Name));
                Console.WriteLine($"{student.Value.FirstName} {student.Value.LastName} from {student.Value.Cohort.CohortName} is working on these exercises: {exerciseList}");
            }

            Console.WriteLine("---------------------------");
        }
    }
}
