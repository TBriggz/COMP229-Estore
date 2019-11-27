using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class FakeRepository
    {
        private static List<CustomerDetails> record = new List<CustomerDetails>();

        public static IEnumerable<CustomerDetails> GetCustomer()
        {
            return record;
        }

        public static void AddNewCustomer(CustomerDetails customer)
        {
            record.Add(customer);
        }

        
    }


}

