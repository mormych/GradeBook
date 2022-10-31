using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    internal class GradeBook
    {
        private static ManageStudent manageStudent = new ManageStudent();
        public static void start()
        {
            bool endProgram = false;
            int input = 0;

            while (!endProgram)
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.Remove student");
                Console.WriteLine("3.Show info about");
                Console.WriteLine("4.Save & exit");
                Console.Write(": ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        manageStudent.addStudent();
                        break;
                    case 3:
                        manageStudent.showInfo();
                        break;
                }
            }
        }
    }
}
