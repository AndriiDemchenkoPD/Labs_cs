namespace Train
{
    class Student
    {
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

    }
    internal class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.id = Guid.NewGuid();
            student.firstName = "Andrii";
            student.lastName = "Demchenko";
            student.middleName = "My";
            student.age = 18;
            student.group = "PD-12";

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine(student.id);
            Console.WriteLine(student.firstName);
            Console.WriteLine(student.lastName);
            Console.WriteLine(student.middleName);
            Console.WriteLine(student.age);
            Console.WriteLine(student.group);
        }
 
       
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}
