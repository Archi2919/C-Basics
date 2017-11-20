using System;

namespace ClassExample
{
    public class Person
    {
        public String FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is: " + FirstName + " " + LastName);
        }
    }
}
