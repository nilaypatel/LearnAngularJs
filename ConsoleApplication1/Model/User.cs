namespace ConsoleApplication1.Model
{
    public class User : IIdentifiable
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //public UserProfile UserProfile { get; set; }
    }
}