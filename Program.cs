using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort cohort26 = new Cohort();
            cohort26.Name = "Day Cohort 26";
            
            Cohort cohort27 = new Cohort();
            cohort27.Name = "Day Cohort 27";
            
            Cohort cohort28 = new Cohort();
            cohort28.Name = "Day Cohort 28";
            
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
                Language = "HTML and CSS"
            };
            
            Exercise chickenMonkey = new Exercise(){
                Name = "Chicken Monkey",
                Language = "JavaScript"
            };

            Exercise fizzBuzz = new Exercise(){
                Name = "Fizz Buzz",
                Language = "JavaScript"
            };

            Exercise loops = new Exercise(){
                Name = "Loops Practice",
                Language = "JavaScript"
            };

            Exercise arrayMethods = new Exercise(){
                Name = "Array Method Practice",
                Language = "JavaScript"
            };

            Exercise NSSIA = new Exercise(){
                Name = "N.S.S.I.A.",
                Language = "JavaScript"
            };

            Exercise dailyJournal = new Exercise(){
                Name = "Daily Journal",
                Language = "JaveScript"
            };

            Exercise nutshellJS = new Exercise(){
                Name = "Nutshell JS",
                Language = "JavaScript"
            };

            Exercise kennel = new Exercise(){
                Name = "Kennel React",
                Language = "React.js"
            };

            Exercise nutshellReact = new Exercise(){
                Name = "Nutshell React",
                Language = "React.js"
            };

            Exercise listPractice = new Exercise(){
                Name = "C# List Practice",
                Language = "C#"
            };

            Exercise tryCatch = new Exercise(){
                Name = "Try and Catch Practice",
                Language = "C#"
            };

            Exercise studentTracker = new Exercise(){
                Name = "Student Tracker",
                Language = "C#"
            };

            Exercise capStone = new Exercise(){
                Name = "Final CapStone",
                Language = "C#"
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

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JSExercises = exercises.Where(e => e.Language == "JavaScript");
            Console.WriteLine("#1");
            Console.WriteLine("JS Exercises:");
            foreach(Exercise exercise in JSExercises)
            {
                Console.WriteLine(exercise.Name);
            }
            Console.WriteLine("---------------------------");
            
            // List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<IGrouping<string, Student>> studentsByCohort = students.GroupBy(s => s.Cohort.Name);
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
            IEnumerable<IGrouping<string, Student>> studentsByCohort2 = students.GroupBy(s => s.Cohort.Name);
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

            var studentsInCohort = students.GroupBy(s => s.Cohort.Name);
            foreach(var grouping in studentsInCohort)
            {
                Console.WriteLine($"{grouping.Key} has {grouping.Count()} students.");
            }
        }
    }
}
