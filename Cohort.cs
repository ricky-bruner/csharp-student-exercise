using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        // public int Id { get; set; }
        public string CohortName { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        
    }
}