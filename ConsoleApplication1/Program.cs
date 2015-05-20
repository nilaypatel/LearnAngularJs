using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfTestDbContext>());
            using (var context = new EfTestDbContext())
            {
                context.Database.CreateIfNotExists();

                Console.WriteLine("Db created...");

                var user1 = new User { Password = "pass", UserName = "user1" };
                var user2 = new User { Password = "pass", UserName = "user2" };

                var uprofile1 = new UserProfile { FirstName = "Fname1", LastName = "Lname1", User = user1 };
                var uprofile2 = new UserProfile { FirstName = "Fname2", LastName = "Lname2", User = user2 };

                context.Set<User>().Add(user1);
                context.Set<User>().Add(user2);
                context.Set<UserProfile>().Add(uprofile1);
                context.Set<UserProfile>().Add(uprofile2);
               
                context.SaveChanges();

                var users = context.Set<User>()
                    .Select(s => new
                    {
                        s.Id,
                        s.UserName
                        
                    })
                    .ToArray();

                foreach (var user in users)
                {
                    Console.WriteLine("Uid: {0}, UName={1}, FName={2}", user.Id, user.UserName, "");
                }
                
                
                Console.ReadLine();
            }
        }
    }
}
