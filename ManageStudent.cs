using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

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
            if(studentList.Count == 0)
            {
                Messages.errorMessage("Empty student list");
                return;
            }
            for(int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + studentList[i].getName());
            }

            Console.WriteLine("Which student? (1 - " + studentList.Count() + ")");
            int id = Convert.ToInt32(Console.ReadLine());
            studentDetail(id);//Showing info about specific student
            //Another menu
            Console.WriteLine("1. Add grades");
            Console.WriteLine("2. Remove grades");
            Console.WriteLine("3. Update info");
            Console.WriteLine("4. Exit");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    addGrade(id);
                    break;
                case 2:
                    //removeGrade(id);
                    break;
                case 3:
                    updateInfo(id);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Undefined option");
                    break;
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

        private void addGrade(int id)
        {
            bool end = false;
            string grade;
            while (!end)
            {
                Console.WriteLine("Grade to add to Student: " + studentList[id - 1].getName());
                Console.WriteLine("Type \"end\" to exit");
                grade = Console.ReadLine();
                if (grade == "end")
                {
                    return;
                }
                else
                {
                    studentList[id - 1].setGrades(Convert.ToInt32(grade));
                }
            }
        }

        private void updateInfo(int id)
        {
            string tempName;
            string tempSurname;
            int tempAge;

            Console.Write("Old name: ");
            Messages.errorMessage(studentList[id - 1].getName());
            Console.Write("New name: ");
            tempName = Console.ReadLine();

            Console.Write("Old surname: ");
            Messages.errorMessage(studentList[id - 1].getSurname());
            Console.Write("New surname: ");
            tempSurname = Console.ReadLine();

            Console.Write("Old age: ");
            Messages.errorMessage(Convert.ToString(studentList[id - 1].getAge()));
            Console.Write("New age: ");
            tempAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******Summary******");

            Console.WriteLine("Old data: ");
            Console.Write("Name   : ");
            Messages.errorMessage(studentList[id - 1].getName());
            Console.Write("Surname: ");
            Messages.errorMessage(studentList[id - 1].getSurname());
            Console.Write("Age    : ");
            Messages.errorMessage(Convert.ToString(studentList[id - 1].getAge()));


            Console.WriteLine("New data:");
            Console.Write("Name   : ");
            Messages.greenMessage(tempName);
            Console.Write("Surname: ");
            Messages.greenMessage(tempSurname);
            Console.Write("Age    : ");
            Messages.greenMessage(Convert.ToString(tempAge));

            Console.Write("Save? Yes/No: ");
            String decision = Console.ReadLine();
            if(decision.ToLower() == "yes")
            {
                studentList[id - 1].setName(tempName);
                studentList[id - 1].setSurname(tempSurname);
                studentList[id - 1].setAge(tempAge);
            }
            Console.WriteLine("done");
        }
    }
}
