using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Category : Entity<int>
    {
        public string CategoryName { get; set; }
        public ICollection<User> Employees { get; set; } // Kategoriye ait çalışanlar
    }
}
