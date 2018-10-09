using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        
    }
}