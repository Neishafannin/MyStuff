namespace LabThree
{
    class Instructor
    {

        private string name;
        private string courseName;

        public Instructor (string name, string courseName)
        {
            this.name = name;
            this.courseName = courseName; 
        }

        public void SetStudentGrade (Student student , int grade)
        {
            student.SetGrade(grade);
        
        }

        public void Print()
        {
            
            System.Console.Write("INSTRUCTOR Name: " + name + "   Course: " + courseName + "     ");

            

        }


    }
}
