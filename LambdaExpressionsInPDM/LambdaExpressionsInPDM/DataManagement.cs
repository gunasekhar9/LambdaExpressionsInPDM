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
            listPersonsInCity.Add(new Person("457926353", "Chandra", "17 Main Street, Newyorrk, NY", 28));
            listPersonsInCity.Add(new Person("457926354", "Nagarjuna", "18 Main Street, Newyorrk, NY", 60));
            listPersonsInCity.Add(new Person("457926355", "NaveenChand", "20 Main Street, Newyorrk, NY", 22));
            listPersonsInCity.Add(new Person("457926348", "Hussain", "21 Main Street, Newyorrk, NY", 10));
        }
        public void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + " \t\tAge :" + person.Age);
            }
        }
    }
}
