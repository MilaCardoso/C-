using System;
using System.Collections.Generic;
using System.IO;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> lListBooks = new List<Books>();

            /*lListBooks.Add(new Books("Horror", "Stephen King", "It"));
            lListBooks.Add(new Books("Diaries", "Carolina Maria de Jesus", "Quarto de despejo"));
            lListBooks.Add(new Books("Political Fiction", "George Orwell", "1984"));*/

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Type of the Book:");
                string inputTypeBook = Console.ReadLine();

                Console.WriteLine("Enter Author of the Book:");
                string inputAuthorBook = Console.ReadLine();

                Console.WriteLine("Enter Title of the Book:");
                string inputTitleBook = Console.ReadLine();

                lListBooks.Add(new Books(inputTypeBook, inputAuthorBook, inputTitleBook));
            }

            //Console.WriteLine(lListBooks.Count);

            //Writing the elements of List in to a File
            foreach (object book in lListBooks)
            {
                /*                Console.WriteLine(((Books)book).sTypeBook);
                                Console.WriteLine(((Books)book).sTitleBook);
                                Console.WriteLine(((Books)book).sAuthorBook);*/
                string writeBook = ("Type  : " + (((Books)book).sTypeBook) + " " +
                                    "Title : " + (((Books)book).sTitleBook) + " " +
                                    "Author: " + (((Books)book).sAuthorBook));  // Create a text string
                File.WriteAllText("fileBook.txt", writeBook);  // Create a file and write the content of writeText to it

                string readBook = File.ReadAllText("fileBook.txt");  // Read the contents of the file
                Console.WriteLine(readBook);  // Output the content
            }

            Console.WriteLine("Enter name of the customer:");
            string inputName = Console.ReadLine();

            Console.WriteLine("Enter contact of the customer:");
            string inputContact = Console.ReadLine();

            Person sPerson01 = new Person(inputName, inputContact);

            string writeText = ("Name: " + sPerson01.sName + " Contact Number" + sPerson01.sContact);  // Create a text string
            File.WriteAllText("filePerson.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filePerson.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

        }
    }
}
