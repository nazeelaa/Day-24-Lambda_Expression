using System;
using System.Collections.Generic;
using System.Linq;

namespace Day24UsingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
        AddRecords(person);
        //Retrieving_TopTwoRecords_ForAgeIs_LessThanSixty(person);
        //CheckingTheAgebetween13and18(person);
        //AverageAge(person);
        // CheckSpecificNamePresentOrNot(person);
        RemoveSpecificName(person);
    }

    private static void AddRecords(List<Person> person)
    {
        person.Add(new Person("2033453", "John", "12MainStreet", 15));
        person.Add(new Person("2033456", "SAM", "13MainStreet", 16));
        person.Add(new Person("2033452", "elan", "14MainStreet", 18));
        person.Add(new Person("2033451", "Smith", "15MainStreet", 45));
        person.Add(new Person("2033458", "Smith", "16MainStreet", 55));
        person.Add(new Person("2033457", "sue", "17MainStreet", 65));
        person.Add(new Person("2033452", "Mac", "18MainStreet", 65));

    }

    private static void Retrieving_TopTwoRecords_ForAgeIs_LessThanSixty(List<Person> person)
    {
        foreach (Person per in person.FindAll(e => (e.Age < 60)).Take(2).ToList())
        {
            Console.WriteLine("Name: " + per.Name + " Age : " + per.Age);
        }
    }

    private static void CheckingTheAgebetween13and18(List<Person> person)
    {
        foreach (Person per in person.FindAll(e => (e.Age > 13 && e.Age < 18)).ToList())
        {
            Console.WriteLine("Name: " + per.Name + " Age : " + per.Age);
        }
    }

    private static void AverageAge(List<Person> person)
    {
        double avgage = person.Average(p => p.Age);
        Console.WriteLine("Average age : " + avgage);

    }

    private static void CheckSpecificNamePresentOrNot(List<Person> person)
    {
        bool name = person.Any(x => x.Name == "John");
        if (name)
            Console.WriteLine("Present ");
        else
            Console.WriteLine("Not Present ");

    }
    private static void RemoveSpecificName(List<Person> person)
    {
        int s = person.RemoveAll(e => e.Name == "John");

        if (s > 0)
        {
            Console.WriteLine("Removed");
        }
        else
        {
            Console.WriteLine("Not Removed");
        }


    }

}
}