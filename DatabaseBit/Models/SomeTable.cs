using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseBit.Models
{
    class SomeTable
    {
        public SomeTable()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; set; }
        public bool IAmMadeByMagic { get; set; }
        public string Title { get; set; }
    }
}
