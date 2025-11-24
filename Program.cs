using System;
using System.Collections.Generic;


namespace _17___Dictionary_Case_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==== Student Management Menu ====");
                Console.WriteLine("1 - Add a new student");
                Console.WriteLine("2 - Remove a student");
                Console.WriteLine("3 - Display all students");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose an option (1–4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Student ID (number): ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string name = Console.ReadLine();
                        if (students.ContainsKey(id))
                        {
                            Console.WriteLine("A student with this ID already exists.");
                        }
                        else
                        {
                            students.Add(id, name);
                            Console.WriteLine("Student added successfully!");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Student ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        if (students.ContainsKey(removeId))
                        {
                            students.Remove(removeId);
                            Console.WriteLine("Student removed!");
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\n--- List of Students ---");
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students found.");
                        }
                        else
                        {
                            foreach (var s in students)
                            {
                                Console.WriteLine($"ID: {s.Key} - Name: {s.Value}");
                            }
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
    

