using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Test
{
    public class Customer : IPerson, IBought
    {
        public static Customer DefaultCustomer = new Customer(null, "Default Customer");

        public Customer(IEnumerable<Customer> parentCollection, string name = null, CustomerType type = CustomerType.New)
        {
            Id = Guid.NewGuid();
            Index = (short)(parentCollection?.Count() ?? 0);
            Name = name;
            Type = type;
        }

        #region Fields

        private CustomerType _type;

        #endregion

        #region Properties

        public string Name { get; set; }

        public CustomerType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnType_Changed();
            }
        }

        public Guid Id { get; set; }
        public short Index { get; set; }

        public List<object> BoughtProducts { get; set; }

        public string GetApplicationName()
        {
            return System.AppDomain.CurrentDomain.FriendlyName;
        }

        public void AddBoughtProduct(object person)
        {
            BoughtProducts.Add(person);
        }

        public void OnType_Changed()
        {
            Debug.Print($"{nameof(Customer)} Type changed to {Type}");
        }

        #endregion
    }
}
