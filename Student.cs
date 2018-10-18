

using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public Student(string firstName, string lastName,string slack, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
            Cohort = cohort;
        }

        public Student(){}
        public List<Exercise> Exercises = new List<Exercise>();

    }
}