
namespace Homework_26_11_2023.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private string Students { get; set; }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
                return false;

            if (char.IsUpper(groupNo[0]))
                return true;

            for (int i = 1; i < groupNo.Length; i++)
            {
                if (char.IsDigit(groupNo[i])) return false;
            }
            return true;
        }
        public void AddStudent()
        {
            if (Students.Length < StudentLimit)
            {

            }

        }
        public void GetStudent
    }
}
