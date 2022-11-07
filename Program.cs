using System.Text;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting parameter
            Console.ForegroundColor = ConsoleColor.White;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //Starting our app
            GradeBook.start();
        }
    }
}