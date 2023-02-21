using System.Text;

namespace Module_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            StringBuilder sb = new StringBuilder();

            var names = from s in classes select s.Students;
            foreach (var name in names)
            {
                sb.Append(string.Join(" ", name.ToArray()));
                sb.Append(" ");
            }

            return sb.ToString().Split(Environment.NewLine.ToCharArray());
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
