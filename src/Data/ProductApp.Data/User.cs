using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; private set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
            IsActive = true;
            IsDeleted = false;
        }
    }
}
