namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Instructor person1 = new Instructor("John", "English");
            Instructor person2 = new Instructor("Mike", "Math");

            Student student1 = new Student("Jane", person1);
            Student student2 = new Student("Joe", person1);
            Student student3 = new Student("Melissa", person2);
            Student student4 = new Student("Matt", person2);

            person1.SetStudentGrade(student1, 95);
            person1.SetStudentGrade(student2, 85);
            person2.SetStudentGrade(student3, 90);
            person2.SetStudentGrade(student4, 92);

            student1.Print();
            student2.Print();
            student3.Print();
            student4.Print();
        }
    }
}
