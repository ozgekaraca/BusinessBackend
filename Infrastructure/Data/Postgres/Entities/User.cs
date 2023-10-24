using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public int CategoryId { get; set; }
    public Category Category { get; set; } // Bir kullanıcının bir kategorisi
    public UserType UserType { get; set; } // Kullanıcı türü

}

public enum UserType
{
    Admin,
    Employee,
}
