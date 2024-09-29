using System;
using System.Collections.Generic;

class Program
{
    // Структура Country, що містить поля для назви країни, кількості населення та частини світу
    struct Country
    {
        public string name;
        public int population;
        public string partOfTheWorld;

        // Метод, що повертає рядок із значеннями полів
        public string Vivod()
        {
            return $"{name} {population} {partOfTheWorld}";
        }
    }

    static void Main(string[] args)
    {
        // Створити список країн
        List<Country> countries = new List<Country>();
        Country country;
        int n = 4;

        // Ввести дані з клавіатури
        Console.WriteLine("Введіть дані:");
        for (int i = 0; i < n; i++)
        {
            country.name = Console.ReadLine();
            country.population = int.Parse(Console.ReadLine());
            country.partOfTheWorld = Console.ReadLine();
            countries.Add(country);
        }

        // Вивести список країн на екран
        Console.WriteLine("Список країн:");
        foreach (var c in countries)
        {
            Console.WriteLine(c.Vivod());
        }

        // Ввести частину світу з клавіатури
        Console.Write("Введіть частину світу: ");
        string part = Console.ReadLine();

        // Знайти кількість країн у цій частині світу та загальну кількість населення
        int count = 0;
        int totalPopulation = 0;
        foreach (var c in countries)
        {
            if (c.partOfTheWorld == part)
            {
                count++;
                totalPopulation += c.population;
            }
        }

        // Вивести результати
        Console.WriteLine($"\nКількість країн у цій частині світу: {count}");
        Console.WriteLine($"Загальна кількість населення країнах цієї частини світу: {totalPopulation}");

        Console.ReadKey();
    }
}