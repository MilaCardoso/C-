using System;
using System.IO;
using System.Collections.Generic;
namespace hello{
    class Start{
        public static void fProgress(int num, int size){
            const int fixSize = 40;
            int bNum = size;
            int progress = ((fixSize * num)/ bNum);
            for( int i = 0; i < progress; i++){
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            for( int j = 0; j < (fixSize-progress); j++){
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine($" {(100*num/size)}%\n");

        }
        static void Main(string[] args){ 
            Question storage = new Question();//create object from the class Question
            string nfile = "questions.txt";//name of the file
            int numOfQ = 0;//number of questions
            int numOfA = 0;//number of answers
            //check if file exists
            if (File.Exists(nfile)){
                //read each line of the file and
                //store it to the object
                foreach ( var line in File.ReadLines(nfile)){
                    storage.AddQuestion(line);
                    numOfQ++;
                }
                //get the whole list from object
                List <string> q = storage.ReadQuestionAll();
                //for each string inside list
                //read it, show it, ask for answer and stroe the answer to object under answers list
                foreach(string que in q){
                    Console.WriteLine(que);
                    Console.WriteLine("Input your answer below:");
                    numOfA++;
                    storage.AddAnswer($"Q{numOfA}#A{numOfA}="+Console.ReadLine());
                    //show progress bar
                    fProgress(numOfA,numOfQ);

                }
                //create new file
                var x = File.Create("answeres.txt");
                x.Close();
                //add all answers from the object into the file
                File.AppendAllLines("answeres.txt",storage.ReadAnswersAll());
            }

        }
    }
}