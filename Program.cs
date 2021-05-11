using System;

namespace Async_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            optionalParam();
        }

        // optional parameters
        static void optionalParam()
        {
            lectures lecture = new lectures(wages: 200);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
            lecture = new lectures(lectureName: "john", wages: 1500);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
        }

        
    }

    class lectures
    {
        public string lectureName;
        public double wages;

        public lectures(double wages, string lectureName = "default lecture")
        {
            this.lectureName = lectureName;
            this.wages = wages;
        }
    }
}
