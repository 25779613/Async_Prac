using System;
using System.Net.Http;
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

            //Asychronos fetch from api 
            Console.WriteLine("<<<<<<<<<<<<<Asynchronos fetch api>>>>>>>>>>>>");
            await AsyncFetchDataApi();

        }


        // optional parameters
        static void optionalParam()
        {
            lectures lecture = new lectures(wages: 200);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
            lecture = new lectures(lectureName: "john", wages: 1500);
            Console.WriteLine(lecture.lectureName + ":" + lecture.wages);
        }

        //asynchronos 
        static async Task asynchronos()
        {
            Console.WriteLine("task1");
            await Task.Delay(3000);
            Console.WriteLine("task2");

        }

        // async fetch from api
        private static HttpClient httpClient = new HttpClient();
        static async Task<dynamic> AsyncFetchDataApi()
        {
            string link = "https://jsonplaceholder.typicode.com/todos";
            var user = await httpClient.GetStringAsync(link);
            Console.WriteLine(user);
            return user;
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
