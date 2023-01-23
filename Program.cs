


namespace OneToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // пересоздадим базу данных
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                User user1 = new User { Login = "login1", Password = "pass1234" };
                User user2 = new User { Login = "login2", Password = "5678word2" };
                db.Users.AddRange(user1, user2);

                UserProfile profile1 = new UserProfile { Age = 22, Name = "Tom", User = user1 };
                UserProfile profile2 = new UserProfile { Age = 27, Name = "Alice", User = user2 };
                db.UserProfiles.AddRange(profile1, profile2);

                db.SaveChanges();
            }



        }
    }
}