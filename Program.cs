﻿namespace GenericDictionaryValuePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grades = new Dictionary<int, string>
            {
                {6, "Perfect" }
            };

            grades.Add(5, "Good");
            grades[4] = "Okay";
            grades[3] = "Almost";
            grades[2] = "Bad";
            grades[1] = "Worse";

            foreach (var grade in grades)
            {

                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
        }
    }
}