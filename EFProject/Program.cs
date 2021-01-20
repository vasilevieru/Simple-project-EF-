using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestContext())
            {
                var person = context.Persons.Include(y => y.Address).Where(x => x.FirstName == "Ion")
                    .ToList();
            }
        }
    }
}
