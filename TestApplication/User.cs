using System;
using System.Collections;
using System.Collections.Generic;

namespace TestApplication
{
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 PhoneNumber { get; set; }

        public static void GenericCollectionWithCustomClass()
        {
            //List<User> users = new List<User>();
            //users.Add(new User { UserId = 1, Name="Tim", Age=15, Email="asd@mail.com", PhoneNumber=53726587});
            //users.Add(new User { UserId = 2, Name = "John", Age = 25, Email = "ad@mail.com", PhoneNumber = 535526587 });
            //users.Add(new User { UserId = 3, Name = "Ann", Age = 35, Email = "sd@mail.com", PhoneNumber = 569726587 });

            List<User> usersNew = new List<User>()
            {
                new User{UserId = 1, Name="Tim", Age=15, Email="asd@mail.com", PhoneNumber=53726587},
                new User{UserId = 2, Name="Jim", Age=15, Email="asd@mail.com", PhoneNumber=53726587},
                new User{UserId = 3, Name="Bob", Age=15, Email="asd@mail.com", PhoneNumber=53726587}

            };

            foreach (var user in usersNew)
            {
                Console.WriteLine($"Users name: {user.Name}, age: {user.Age}, email: {user.Email}");
            }
        }

        public static void NonGenericCollection()
        {
            Hashtable table = new Hashtable();
            table.Add("UserName", "ea");
            table.Add("Password", "ea123");
            table.Add("Button", "Submit");

            Console.WriteLine("The username is: " + table["UserName"]);
            Console.WriteLine("The password is: " + table["Password"]);
            Console.WriteLine("The button is: " + table["Button"]);

            foreach (var key in table.Keys)
            {
                Console.WriteLine("Value for " + key + " is: " + table[key]);

            }
        }

        public static void GenericCollection()
        {
            string[] user1 = new string[] { "John", "30", "ea@gmail.com", "4444444" };
            string[] user2 = new string[] { "Sam", "32", "aa@gmail.com", "5554444" };
            string[] user3 = new string[] { "Will", "20", "ag@gmail.com", "8888888" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();

            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);

            foreach (var value in dict)
            {
                string[] usersInfo = value.Value;

                foreach (var user in usersInfo)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }

}
