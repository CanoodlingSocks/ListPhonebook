using System;
using System.Collections.Generic;

namespace ListPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Person person = new();
                Console.WriteLine("Choose option");
                Console.WriteLine("1. Add new entry to phonebook 2. List entries in phonebook 3. Remove entry in phonebook");
                Console.WriteLine("4. Exit");
                ConsoleKey input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        person.AddPerson();    
                        break;
                    
                    case ConsoleKey.D2:
                        Console.Clear();
                        person.ListPeople();
                        break;
                    
                    case ConsoleKey.D3:
                        Console.Clear();
                        person.RemovePerson();
                        break;
                    
                    case ConsoleKey.D4:
                        Console.WriteLine("Shutting down. . .");
                        Console.ReadLine();
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Did not recognize input. . .");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
