using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Data.Models
{
    public class Entity
    {
        protected Entity()
        {
            CreateDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }

        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
