using System.Linq;

namespace ProgressCheck.DatabaseConnection
{
    public partial class User
    {
        public Role UserRole => Connection.Entities.Role.First(role => role.ID == Role_ID);
    }

    public enum Roles
    {
        Admin = 1,
        Client
    }
}