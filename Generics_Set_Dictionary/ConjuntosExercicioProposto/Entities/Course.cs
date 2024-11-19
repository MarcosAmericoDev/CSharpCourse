using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConjuntosExercicioProposto.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public HashSet<Student> Enrollees { get; set; }

        public Course(string name)
        {
            Name = name;
            Enrollees = new HashSet<Student>();
        }

        public void AddStudent(Student student)
        {
            Enrollees.Add(student);
        } 
    }
}
