
using System.Security.Cryptography.X509Certificates;

namespace Homework_26_11_2023.Models
{
    public class Student
    {
        private static int _stageId = 1;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }

        public Student (string fullname, int point)
        {
            Id=_stageId++;
            Fullname = fullname;
            Point = point;


        }
        public void StudentInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id: {Id}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fullname: {Fullname}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Point: {Point}");
            Console.ResetColor();

        }
    }
}
