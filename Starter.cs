using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var source = new List<User>
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Ihor",
                    LastName = "Serdjuk",
                    Age = 23,
                    BirthDate = DateTime.Now.AddYears(-10),
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Taras",
                    LastName = "Serdjuk",
                    Age = 37,
                    BirthDate = DateTime.Now.AddYears(-11),
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Dmitriy",
                    LastName = "Serdjuk",
                    Age = 55,
                    BirthDate = DateTime.Now.AddYears(-12),
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Georgij",
                    LastName = "Serdjuk",
                    Age = 8,
                    BirthDate = DateTime.Now.AddYears(-13),
                },
                new User()
                {
                    Id = 5,
                    FirstName = "Valentin",
                    LastName = "Serdjuk",
                    Age = 15,
                    BirthDate = DateTime.Now.AddYears(-14),
                },
                new User()
                {
                    Id = 6,
                    FirstName = "Peter",
                    LastName = "Serdjuk",
                    Age = 22,
                    BirthDate = DateTime.Now.AddYears(-15),
                },
                new User()
                {
                    Id = 7,
                    FirstName = "Gennadij",
                    LastName = "Kernes",
                    Age = 27,
                    BirthDate = DateTime.Now.AddYears(-16),
                }
            };

            var firstOlder30 = source.FirstOrDefault(item => item.Age > 30);
            var allOlder30 = source.Where(item => item.Age > 30);
            var collectionLastNames = source.Select(item => item.LastName);
            var isAnyOlder50 = source.Any(item => item.Age > 50);
            var countOlder20 = source.Count(item => item.Age > 20);
            var grouped = source.GroupBy(item => item.LastName);
        }
    }
}