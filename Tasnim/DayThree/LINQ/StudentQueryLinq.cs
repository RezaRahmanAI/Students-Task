// StudentQuery.cs
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyStudentApp.Queries
{
    public static class StudentQuery
    {
        public static void QuerySyntax(List<Student> students)
        {
            Console.WriteLine("\nAll things comes from Query LINQ\n");     // Question 1
            var ageOver20Query =
                from s in students
                where s.Age > 20
                select s;

            Console.WriteLine("\nStudents over 20:");
            foreach (var s in ageOver20Query)
                Console.WriteLine(s.Name);

            // Question 2
            var marksOver80Query =
                from s in students
                where s.Marks >= 80
                select s;

            Console.WriteLine("\nStudents with Marks >= 80:");
            foreach (var s in marksOver80Query)
                Console.WriteLine(s.Name);

            // Question 3
            var studentNameQuery =
                from s in students
                orderby s.Name
                select s;

            Console.WriteLine("\nStudents sorted alphabetically:");
            foreach (var s in studentNameQuery)
                Console.WriteLine(s.Name);

            // Question 6
            var minAgeQuery = (from s in students select s.Age).Min();
            var minAgeStudentsQuery =
                from s in students
                where s.Age == minAgeQuery
                select s;

            Console.WriteLine("\nYoungest students:");
            foreach (var s in minAgeStudentsQuery)
                Console.WriteLine($"{s.Name}, {s.Age} years");

            // Question 9
            var gradedGroupsQuery =
                from s in students
                let grade = s.Marks >= 90 ? "A+" :
                            s.Marks >= 80 ? "A" :
                            s.Marks >= 70 ? "B" :
                            s.Marks >= 60 ? "C" : "F"
                group s by grade into g
                select g;

            Console.WriteLine("\nStudents grouped by grade:");
            foreach (var g in gradedGroupsQuery)
            {
                Console.WriteLine($"\nGrade {g.Key}:");
                foreach (var s in g)
                    Console.WriteLine($"{s.Name} ({s.Marks})");
            }

            // Question 10: Age > 20 and Marks >= 85
            var filteredStudentsQuery =
                from s in students
                where s.Age > 20 && s.Marks >= 85
                select s;

            Console.WriteLine("\nStudents with Age > 20 and Marks >= 85:");
            foreach (var s in filteredStudentsQuery)
                Console.WriteLine(s.Name);

            // Question 11: Top 2 Students
            var topTwoStudentsQuery =
                (from s in students
                 orderby s.Marks descending
                 select s).Take(2);

            Console.WriteLine("\nTop 2 Students:");
            foreach (var s in topTwoStudentsQuery)
                Console.WriteLine($"{s.Name} ({s.Marks})");
        }
    }

}
