﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_DataBase
{
    internal static class MockData
    {
        internal static List<User> GetMockedUsers()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            User bob = new User()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Bobsky"
            };
            User mark = new User()
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Dean",
                Friends = new List<User>() { john, bob }
            };
            User harry = new User()
            {
                Id = 4,
                FirstName = "Harry",
                LastName = "O'Connel",
                Friends = new List<User>() { mark }
            };
            User jina = new User()
            {
                Id = 5,
                FirstName = "Jina",
                LastName = "Johnson",
                Friends = new List<User>() { harry, bob, john }
            };
            return new List<User>() { john, bob, harry, mark, jina };
        }

        internal static List<Admin> GetAdmins()
        {
            var jully = new Admin()
            {
                Id = 1,
                FirstName = "Jully",
                LastName = "Tompson",
                Friends = new List<User>()
                {
                    new User(){Id = 2, FirstName = "Bob", LastName = "Bobsky"},
                    new User(){Id = 3, FirstName = "Mark", LastName = "Dean"}
                }
            };
            var tom = new Admin()
            {
                Id = 2,
                FirstName = "Tom",
                LastName = "Jackson",
                Friends = new List<User>()
                {
                    new User(){Id = 1, FirstName = "John", LastName = "Doe"},
                    new User(){Id = 3, FirstName = "Mark", LastName = "Dean"}
                }

            }; 
            var jenifer = new Admin()
            {
                Id = 3,
                FirstName = "Jenifer",
                LastName = "Doe",
                Friends = new List<User>()
                {
                    new User(){Id = 3, FirstName = "Mark", LastName = "Dean"},
                    new User(){Id = 4, FirstName = "Harry", LastName = "O'Connel"}
                }
            }; 
            var peter = new Admin()
            {
                Id = 4,
                FirstName = "Peter",
                LastName = "Pan",
                Friends = new List<User>()
                {
                    new User(){Id = 1, FirstName = "John", LastName = "Doe"},
                    new User(){Id = 3, FirstName = "Mark", LastName = "Dean"},
                    new User(){Id = 5, FirstName = "Jina", LastName = "Johnson"}
                }
            }; 
            var mike = new Admin()
            {
                Id = 5,
                FirstName = "Mike",
                LastName = "Johnson",
                Friends = new List<User>()
                {
                    new User(){Id = 1, FirstName = "John", LastName = "Doe"},
                    new User(){Id = 3, FirstName = "Mark", LastName = "Dean"},
                    new User(){Id = 4, FirstName = "Harry", LastName = "O'Connel"},
                    new User(){Id = 5, FirstName = "Jina", LastName = "Johnson"}
                }
            };
            return new List<Admin>() { jully, tom, jenifer, peter, mike };
        }
    }
}
