using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPhonebook
{
    class Person
    {
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }

        public static List<Person> Phonebook = new List<Person>();
        public void AddPerson()
        {
            Person person = new();
            Console.Write("Enter name: ");
            person.FirstName = Console.ReadLine().ToUpper();
            Console.Write("\nEnter phonenumber: ");
            person.PhoneNumber = Console.ReadLine();

            Phonebook.Add(person);
        }

        public static void PrintPhonebook(Person person)
        {
            Console.WriteLine("Name: " + person.FirstName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("_____________________________________");
        }

        public void ListPeople()
        {
            if(Phonebook.Count == 0)
            {
                Console.WriteLine("There are no entries. . .");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Current entries:\n");
            foreach (var person in Phonebook)
            {
                PrintPhonebook(person);
            }
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }

        public void RemovePerson()
        {
            Console.WriteLine("Which name do you want to remove?");
            
            foreach (var person in Phonebook)
            {
                PrintPhonebook(person);
            }
            Console.WriteLine("Enter a number (starting from 0 from the top) for the entry you want to remove");
            
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Phonebook.Remove(Phonebook[input]);
                Console.WriteLine($"\nThe entry at index [{input}] has been removed.");
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpexted error: {exception.Message}");
                Console.ReadLine();
            }

        }
    }
}
