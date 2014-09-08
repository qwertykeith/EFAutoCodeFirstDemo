using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseBit.Models
{
    class SomeOtherTable
    {
        public SomeOtherTable()
        {
            ID = Guid.NewGuid();
            ALinkedTable = new List<SomeTable>();
        }

        public Guid ID { get; set; }
        public string SomeField { get; set; }
        public string SomeField2 { get; set; }
        public int AnInteger { get; set; }
        public SomeSharedData Stuff { get; set; }

        public List<SomeTable> ALinkedTable { get; set; }
    }
}
