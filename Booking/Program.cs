using System;
using System.IO;
using System.Globalization;

namespace Booking
{
    class Program 
    {
        public static void Main(string[] args) 
        {
                //string path = @"C:\Users\Camila\Desktop\C#\Booking\booking.txt";
                //string path = @"C:\Users\Client 0819\Desktop\Projects\Booking\booking.txt";
                string path = "booking.txt";
               
                string appendText = "Little Shop of Horrors 18/11/2019\n";

                string seats = "";

                for (int i = 0; i < 10; i++)
                {
                  for (int j = 0; j < 20; j++)
                  {
                    seats = seats + "F";
                  }
                  seats = seats + "\n"; 
                }   

                string writeFile = appendText + seats;
                File.WriteAllText(path, writeFile); 
                
/*                 // Open the file to read from.
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText); */

                foreach (var eachLineFile in File.ReadLines(path)) {
                  bool titlePlay = eachLineFile.Contains("/");
                  if (titlePlay == true){
                      Console.WriteLine(eachLineFile);
                      Console.WriteLine(titlePlay); 
                      string[] words = eachLineFile.Split(' ');
                      //foreach (var word in words)
                      //{
                        System.Console.WriteLine($"<{words[words.Length -1 ]}>");
                        DateTime newdate;
                        var date = $"<{words[words.Length -1 ]}>";
                        if (DateTime.TryParse(date, out newdate)) {
                          Console.WriteLine("Date Validate!"); 
                        } else {
                          Console.WriteLine("Date Invalid"); 
                          Console.WriteLine(date); 
                          Console.WriteLine(newdate); 
                        }
                  }
                }

                /* string phrase = "The quick brown fox jumps over the lazy dog.";
                string[] words = phrase.Split(' ');

                foreach (var word in words)
                {
                  System.Console.WriteLine($"<{word}>");
                } */

/*                 DateTime temp;
                if(DateTime.TryParse(startDateTextBox.Text, out temp))
                {
                // Yay :)
                }
                else
                {
                // Aww.. :(
                } */
        }
    }
}