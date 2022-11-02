using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        private string name;
        private string surname;
        private int age;
        private List<int> grades;

        public Student()
        {

        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            grades = new List<int>();
        }

        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public int getAge()
        {
            return age;
        }
        public List<int> getGrades()
        {
            return grades;
        }

        public void setGrades(int grade)
        {
            grades.Add(grade);
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }


        public override string ToString()
        {
            return ("student name: " + name + " surname: " + surname + " age:  " + age);
        }
    }
}
