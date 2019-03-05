using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer:IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
        }

        public override string ToString()
        {
            return $"ID:{this.Id}, Name:{this.Name}, Birth year:{this.BirthYear}, Address{this.Address}, Protection:{this.Protection}";
        }

        public int CompareTo(Customer other)
        {
            return this.Id - other.Id;
        }
    }


    class SortByProtection : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Protection - y.Protection;
        }
    }

    class SortByTotalPurchases : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.TotalPurchases - y.TotalPurchases;
        }
    }

    class SortByBirthYear : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return -1*(x.BirthYear - y.BirthYear);
        }
    }
}
