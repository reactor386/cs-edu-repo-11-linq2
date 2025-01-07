# cs-edu-repo-11-linq2
Модуль 15. Основы LINQ. Часть 2. 15.6.6. Практическое задание (HW-03)

**Практика**

Есть список учеников школы с разбивкой по классам:

<details><summary> code block </summary>

```
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Task1
{
    class Program
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
            // ???
        }
      
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
```

</details>

Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ
