using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollectionsProject {

    public class Customers {

        List<Customer> customerList = new List<Customer>();

        public void LoadCustomers() {
            var cust1 = new Customer { Name = "P&G", State = "OH" };
            var cust2 = new Customer { Name = "Microsoft", State = "WA" };
            var cust3 = new Customer { Name = "Target", State = "MN" };

            customerList.Add(cust1);
            customerList.Add(cust2);
            customerList.Add(cust3);
        }

        public void PrintCustomers() {
            foreach(var cust in customerList) {
                cust.
                Console.WriteLine($"Customer {cust.Name} is in the state of {cust.State}");
            }
        }

    }
    public class Customer {
        public string Name { get; set; }
        public string State { get; set; }
    }
}
