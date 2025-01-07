// -
using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        var classes = new []
        {
            new Classroom { Students = { "Evgeniy", "Sergey", "Andrew" }, },
            new Classroom { Students = { "Anna", "Viktor", "Vladimir" }, },
            new Classroom { Students = { "Bulat", "Alex", "Galina" }, }
        };
        var allStudents = GetAllStudents(classes);
        
        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes)
    {
        string[] allStudents = [];

        // simply flatten 'lists of lists' with [SelectMany()] as it needs in the task
        allStudents = classes.SelectMany(x => x.Students).ToArray();

        /*
        // extra example:
        // use [SelectMany()] overload with resultSelector parameter
        //  to include data from the parent lists
        allStudents = classes.SelectMany(x => x.Students,
            (parentItem, childSingleItem) => new
            {
                classCount = parentItem.Students.Count,
                studentName = childSingleItem
            })
            .Select(s => $"{s.studentName} has {s.classCount} classmates").ToArray();
        */

        return allStudents;
    }
    
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
