using DatabaseBit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DatabaseBit.Contexts
{
    class SomeDBContext : DbContext
    {
        public DbSet<SomeOtherTable> IAmATable { get; set; }
        public DbSet<SomeTable> ALinkedTable { get; set; }
    }
}
