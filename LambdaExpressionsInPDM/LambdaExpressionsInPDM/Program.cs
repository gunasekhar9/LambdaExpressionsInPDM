﻿using System;
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
        }
    }
}