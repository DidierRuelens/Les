using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Les.Models
{
    public class DBInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

        }
    }
}
