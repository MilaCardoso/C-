using System;
using System.IO;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the file to read from.
            string path = "questions.txt";
            Myquestions questions = new Myquestions();
            
            foreach (var eachLineFile in File.ReadLines(path)) 
            {
                string[] questionInfo = eachLineFile.Split('#');
                System.Console.WriteLine($"<{questionInfo[0]}>");
            }	
        }
    }
}
