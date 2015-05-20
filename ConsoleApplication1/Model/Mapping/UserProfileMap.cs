using System.Data.Entity.ModelConfiguration;

namespace ConsoleApplication1.Model.Mapping
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            ToTable("UserProfile", "user");

            HasKey(up => up.UserId);

            Property(up => up.FirstName);

            Property(up => up.LastName);

            HasRequired(up => up.User)
                .WithOptional();
        }
    }
}