using System;
using System.Collections.Generic;

namespace LambdaExpressionsInPDM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expressions in Person Data Management");
            DataManagement data = new DataManagement();
            List<Person> listPersonsInCity = new List<Person>();
            data.AddRecords(listPersonsInCity);
            data.Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonsInCity);
            data.CheckingForTeenagePerson(listPersonsInCity);
            data.CheckingforSpecificNamePresent(listPersonsInCity);
            data.CheckingforAverageAgePerson(listPersonsInCity);
            data.SkippingTheRecordFromTheList(listPersonsInCity);
            data.RemoveSpecificNameFromTheList(listPersonsInCity);
        }
    }
}
