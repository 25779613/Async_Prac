using System;
using System.Threading.Tasks;

namespace Async_Prac
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //How to use optional parameters
            Console.WriteLine("<<<<<<<<<<<<<Optional Parameters>>>>>>>>>>>>");
            optionalParam();

            //Asychronos 
            Console.WriteLine("<<<<<<<<<<<<<Asynchronos>>>>>>>>>>>>");
            await asynchronos();

        }


        // optional parameters
        static void optionalParam()
        {
            lectures lecture = new lectures(wages: 200);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
            lecture = new lectures(lectureName: "john", wages: 1500);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
        }

        //aysnchronos 
        static async Task asynchronos()
        {
            Console.WriteLine("task1");
            await Task.Delay(3000);
            Console.WriteLine("task2");

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
