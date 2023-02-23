using System;
using System.Linq;
using System.Collections.Generic;

public class Person
{
    public string name { get; set; }
    public int grade { get; set; }

    public Person(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }

    public override string ToString()
    {
        return "[" + name + ", " + grade + "]";
    }
}

public class Program
{
    public static void Main()
    {
        List<Person> list = new List<Person> 
        {
                new Person("Anna", 5), new Person("Elena", 4),
                new Person("Bpb", 8), new Person("Tim", 12),
                new Person("Sedrik", 10), new Person("George", 11),
                new Person("Dina", 9), new Person("Sem", 10)
        };

        List<Person> filteredList = list.Where(item => item.grade > 9).ToList();
        Console.WriteLine(String.Join(", ", filteredList));
        Console.ReadLine();
    }
}



