using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            

            /* Type your username and press enter
            Console.WriteLine("**************************************");
            Console.WriteLine("***         Enter username:        ***");
            Console.WriteLine("**************************************");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName); */

            /* Switch
            Console.WriteLine("**************************************");
            Console.WriteLine("*** Enter a number between 1 to 12 ***");
            Console.WriteLine("**************************************");

            string month = Console.ReadLine();

            Console.WriteLine("Month is: " + month);

            switch (month) 
            {
                case "1":
                    Console.WriteLine("January");
                    break;
                case "2":
                    Console.WriteLine("February");
                    break;
                case "3":
                    Console.WriteLine("March");
                    break;
                case "4":
                    Console.WriteLine("April");
                    break;
                case "5":
                    Console.WriteLine("May");
                    break;
                case "6":
                    Console.WriteLine("June");
                    break;
                case "7":
                    Console.WriteLine("July");
                    break;
                case "8":
                    Console.WriteLine("August");
                    break;
                case "9":
                    Console.WriteLine("September");
                    break;
                 case "10":
                    Console.WriteLine("October");
                    break;
                 case "11":
                    Console.WriteLine("November");
                    break; 
                 case "12":
                    Console.WriteLine("December");
                    break;     
            } */
            
            /* Array and Conditions
            string[] citys = {"Dublin", "Florianopolis", "London"};
            Console.WriteLine(citys[0]);

            if (citys[1] == "Florianopolis") 
            {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            } */

            // Console.WriteLine(Math.Max(5, 10));     

            /* try 
            {
                int[] numbers = {1, 2, 3};
                Console.WriteLine(numbers[1]);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished."); 
            }       */


            // Exercise to practice          

/*              do {
                Console.WriteLine("Enter number 1 - between 0 to 50:");
                string num1 = Console.ReadLine();
           
                Console.WriteLine("Enter number 2 - between 0 to 50:");
                string num2 = Console.ReadLine();

                int numI1 = Int32.Parse(num1);
                int numI2 = Int32.Parse(num2);
                if (numI1 <= 50 && numI2 <= 50) {
                    int total = numI1 + numI2;

                    if (total > 100) {
                        Console.WriteLine("The total is bigger than 100");
                    } else {
                        if (total == 100) {
                            Console.WriteLine("Bingo! \nTotal: " + total); 
                              
                        } else {
                            Console.WriteLine("No Bingo \nTotal: " + total); 
                             
                        }  
                        CheckProgress(total);
                        NumberReturn(0,100); 
                        break;
                    }   
                } else {
                    Console.WriteLine("******************** WARNING ************************"); 
                    Console.WriteLine("The numbers need to be less than 50. Please try again");     
                    Console.WriteLine("******************** WARNING ************************");   
                }                 
            } while (true);   */

            int i = 0;
            //for (int i = 0; i < 5; i++) {
            while (! Console.KeyAvailable)
            {
                /* int total =  NumberReturn(0,100);
                CheckProgress(total);   */
                Console.WriteLine("Loading...");  
                System.Threading.Thread.Sleep(2000); 
                CheckProgress(NumberReturn(0,100));    
                i ++;
                if (i > 4) {
                    Console.Clear();
                    i = 0;
                }       
            }

        }

        static void CheckProgress(int total)
        {              
            const int numbCalc = 40;
            const int calc100 = 100;

            int numProgress = (numbCalc * total) / calc100;
            int numLeft = (int)(numbCalc - numProgress);
                
            for (int i = 0; i < numProgress; i++) {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");  
            }
            for (int j = 0; j < numLeft; j++) {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Write(" ");  
            }
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.WriteLine(" " + total + "%\n");
            } 

 /*            static int NumberReturn(int max, int number1, int number2)
            {              
/*                 int minimum = number2; 
                if (number1 < number2) {
                    minimum = number1; 
                } 
                //Console.Write("minimum is:" + minimum); 
                //return minimum; 
                
                return Math.Max(max, Math.Max(number1, number2)); */
            static int NumberReturn(int min, int max) 
            {
                var ValCal = new Random();
                return ValCal.Next(min, max);
            } 
    }
}
