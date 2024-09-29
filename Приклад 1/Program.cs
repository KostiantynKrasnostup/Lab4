using System;
using System.Collections.Generic;

class Program
{
    struct Lud
    {
        public string f;
        public int gr;  
        public char p;

        public string Vivod()
        {
            return $"{f} {gr} {p}";
        }
    }

    static void Main(string[] args)
    {
        List<Lud> students = new List<Lud>();
        Lud stud;
        Lud mx = new Lud();
        int n = 4;

        Console.WriteLine("Введіть дані:");
        for (int i = 0; i < n; i++)
        {
            stud.f = Console.ReadLine();
            stud.gr = int.Parse(Console.ReadLine());  
            stud.p = char.Parse(Console.ReadLine());  
            students.Add(stud);
        }

        Console.WriteLine("Список студентів:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(students[i].Vivod());
        }

        for (int i = 0; i < n; i++)
        {
            if (students[i].p == 'ж' &&
                (mx.gr == 0 || students[i].gr < mx.gr))  
            {
                mx = students[i];
            }
        }

        if (mx.gr != 0)
            Console.WriteLine("\nНаймолодша студентка: {0} {1} {2}",
                mx.f, mx.gr, mx.p);
        else
            Console.WriteLine("\nНемає дівчин");

        Console.ReadKey();
    }
}
