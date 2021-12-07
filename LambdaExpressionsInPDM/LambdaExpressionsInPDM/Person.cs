using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressionsInPDM
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Addrress;
        public int Age;

        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Addrress = addr;
            Age = age;
        }
    }
}