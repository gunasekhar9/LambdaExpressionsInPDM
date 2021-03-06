using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionsInPDM
{
    public class DataManagement
    {
        public void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("457926348", "John", "12 Main Street, Newyorrk, NY", 55));
            listPersonsInCity.Add(new Person("457926349", "Sai", "13 Main Street, Newyorrk, NY", 16));
            listPersonsInCity.Add(new Person("457926350", "Hari", "14 Main Street, Newyorrk, NY", 40));
            listPersonsInCity.Add(new Person("457926351", "Jilani", "15 Main Street, Newyorrk, NY", 34));
            listPersonsInCity.Add(new Person("457926352", "Ali", "16 Main Street, Newyorrk, NY", 49));
            listPersonsInCity.Add(new Person("457926353", "Chandra", "17 Main Street, Newyorrk, NY", 69));
            listPersonsInCity.Add(new Person("457926354", "Nagarjuna", "18 Main Street, Newyorrk, NY", 60));
            listPersonsInCity.Add(new Person("457926355", "NaveenChand", "20 Main Street, Newyorrk, NY", 22));
            listPersonsInCity.Add(new Person("457926356", "Hussain", "21 Main Street, Newyorrk, NY", 65));
            listPersonsInCity.Add(new Person("457926357", "Narendra", "22 Main Street, Newyorrk, NY", 28));
        }
        public void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + " \t\tAge :" + person.Age);
            }
        }
        public void CheckingForTeenagePerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
        }
        public void CheckingforSpecificNamePresent(List<Person> listPersonInCity)
        {
            Console.WriteLine("Search for Name ");
            string Search = Console.ReadLine();
            if (listPersonInCity.Any(e => (e.Name == Search)))
            {
                Console.WriteLine("Yes, we have That Named Person in the List ");
            }
            else
            {
                Console.WriteLine("That Person is not the List");
            }
        }
        public void CheckingforAverageAgePerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 35 && e.Age < 45)))
            {
                Console.WriteLine("Yes, we have some Average-agers in list");
            }
        }
        public void SkippingTheRecordFromTheList(List<Person> listPersonInCity)
        {
            Console.WriteLine("After Skipping, the Remaining Persons are : ");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age > 60)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\tAge : " + person.Age);
            }
        }
        public void RemoveSpecificNameFromTheList(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter The Name To Remove From The List");
            string Remove = Console.ReadLine();
            if (listPersonInCity.Exists(e => e.Name == Remove))
            {
                var remove = listPersonInCity.RemoveAll(e => e.Name.Contains(Remove));
                Console.WriteLine("The Name {0} is Removed from the list", Remove);
            }
            else
            {
                Console.WriteLine("The Name -- {0}  is Not in the List", Remove);
            }
        }
    }
}