using DatabaseBit.Contexts;
using DatabaseBit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseBit.SomeService
{
    public class SomeServiceOrSomething
    {
        public IEnumerable<string> GetSomeWords()
        {
            using (var ctx = new SomeDBContext())
            {
                return ctx.IAmATable
                    .Select(w => w.SomeField)
                    .OrderBy(w => w)
                    .ToList();
            }
        }

        public void AddSomeData(string words)
        {
            // you could inject the context too.. and aparently you can mock it if you need to
            using (var ctx = new SomeDBContext())
            {
                var newthing = new SomeOtherTable()
                {
                    AnInteger = 666,
                    SomeField = DateTime.Now.ToLongTimeString() + "-" + words,
                    SomeField2 = "more " + words,
                    Stuff = new Models.SomeSharedData()
                    {
                        Hello = "more data",
                        HiThere = 101,
                        TrueOrFalse = false,
                    },
                };


                newthing.ALinkedTable.Add(new SomeTable() { Title = "linked to " + words });
                newthing.ALinkedTable.Add(new SomeTable() { Title = "linked to " + words + " also" });

                ctx.IAmATable.Add(newthing);




                ctx.SaveChanges();
            }
        }
    }
}
