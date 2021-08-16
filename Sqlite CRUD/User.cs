using System.ComponentModel.DataAnnotations;

namespace Sqlite_CRUD
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}