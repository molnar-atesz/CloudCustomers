using System.Collections.Generic;
using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UserFixtures
{
    public static List<User> GetTestUsers()
    {
        return new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Test Elek",
                Address = new Address {Street = "Sezame", City = "New york", ZipCode = "1234"},
                Email = "test@example.com"
            },
            new User
            {
                Id = 2,
                Name = "Test John",
                Address = new Address {Street = "Bum", City = "London", ZipCode = "4321"},
                Email = "john@example.com"
            },
            new User
            {
                Id = 3,
                Name = "Test Jane",
                Address = new Address {Street = "aaaa", City = "Budapest", ZipCode = "1137"},
                Email = "jane@example.com"
            }
        };
    }
}