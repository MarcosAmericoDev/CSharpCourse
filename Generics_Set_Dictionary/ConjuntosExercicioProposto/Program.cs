/* Em um portal de cursos online, cada usuário possui um código único, representado por
um número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
alunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
quantidade total e alunos dele, conforme exemplo. 
How many students for course A? 3
21
35
22
How many students for course B? 2
21
50
How many students for course C? 3
42
35
13
Total students: 6
 
 */

using ConjuntosExercicioProposto.Entities;
using System.Reflection.PortableExecutable;

namespace ConjuntosExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<Course> courses = new HashSet<Course>() { new Course("A"), new Course("B"), new Course("C") };

            HashSet<Student> totalStudentsSet = new HashSet<Student>();
            foreach (Course course in courses)
            {
                Console.Write($"How many students for course {course.Name}? ");
                int numStudents = int.Parse(Console.ReadLine());
                for (int i = 0; i < numStudents; i++)
                {
                    int studentId = int.Parse(Console.ReadLine());
                    Student student = new Student() { Id = studentId };
                    course.AddStudent(student);
                }
                totalStudentsSet.UnionWith(course.Enrollees);
            }
            Console.WriteLine($"Total students: {totalStudentsSet.Count}");
        }
    }
}
