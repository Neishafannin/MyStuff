namespace LabThree
{
    class Student
    {
        private string name;
        private int grade;
        private Instructor teacher;


        public Student (string name, Instructor teacher)
        {
            this.name = name;
            this.teacher = teacher;
            this.grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

        public void Print()
        {
            teacher.Print();
            System.Console.WriteLine("STUDENT  Name: " + name + "   Grade: " + grade);
            
           

        }

    }
}
