using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique.Linq
{
    class EntryPoint
    {
        public static void Main()
        {
            List<User> users = new List<User>();
            users.Add(new User() { Name = "aamir", Address = "karachi", Email = "aamir@hotmail.com", Gender = "male" });
            users.Add(new User() { Name = "ateeq", Address = "canada", Email = "ateeq@hotmail.com", Gender = "male" });
            users.Add(new User() { Name = "bushra", Address = "US", Email = "bushra@hotmail.com", Gender = "female" });
            users.Add(new User() { Name = "noman", Address = "US", Email = "noman@hotmail.com", Gender = "male" });
            users.Add(new User() { Name = "huma", Address = "italy", Email = "huma@hotmail.com", Gender = "female" });
            users.Add(new User() { Name = "ali", Address = "karachi", Email = "ali@hotmail.com", Gender = "male" });
            users.Add(new User() { Name = "ayesha", Address = "canada", Email = "ayesha@hotmail.com", Gender = "female" });
            users.Add(new User() { Name = "maryam", Address = "italy", Email = "maryam@hotmail.com", Gender = "female" });

            List<User> usersResult = users.Where(u => u.Address == "karachi").ToList(); //where equivalent of sql

            usersResult = users.Where(u => u.Gender == "female").ToList(); //where equivalent of sql

            usersResult = users.Take(4).ToList(); //just like top in sql

            bool isMale = users.Exists(u => u.Gender == "male");

            User firstUser = users.First();

            User lastUser = users.Last();

            int count = users.Count;

            usersResult = users.OrderBy(u => u.Name).ToList();

            List<string> names = users.OrderByDescending(u => u.Name).ToList().Select(u => u.Name).ToList();
        }

        public class User
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
        }
    }
}
