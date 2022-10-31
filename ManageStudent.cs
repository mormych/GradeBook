using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GradeBook
{
    public class ManageStudent : Student
    {

        private static List<Student> studentList = new List<Student>();

        public ManageStudent()
        {

        }

        public int addStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            studentList.Add(new Student(name, surname, age));

            return 0;
        }

        public void showInfo()
        {
            for(int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + studentList[i].getName());
            }

            Console.WriteLine("Which student? (1 - " + studentList.Count() + ")");
            int id = Convert.ToInt32(Console.ReadLine());
            studentDetail(id);
            bool end = false;
            string grade;
            while (!end)
            {
                Console.WriteLine("Grade to add to Student: " + studentList[id - 1].getName());
                Console.WriteLine("Type \"end\" to exit");
                grade = Console.ReadLine();
                if(grade == "end")
                {
                    return;
                }
                else
                {
                    studentList[id - 1].setGrades(Convert.ToInt32(grade));
                }
            }
        }

        private void studentDetail(int id)
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Name      : " + studentList[id-1].getName());
            Console.WriteLine("Surname   : " + studentList[id - 1].getSurname());
            Console.WriteLine("Age       : " + studentList[id - 1].getAge());
            Console.Write("Grades    : ");
            if(studentList[id - 1].getGrades().Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (int grade in studentList[id - 1].getGrades())
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
