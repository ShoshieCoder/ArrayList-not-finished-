using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyQueue
    {
        private List<Customer> _customers = new List<Customer>();

        public void Enqueue(Customer customer)
        {
            _customers.Insert(0, customer);
        }

        public MyQueue()
        {
            
        }

        public Customer Dequeue()
        {
            if (_customers.Count > 0)
            {
                Customer result = _customers[0];
                _customers.RemoveAt(0);
                return result;
            }
            return null;
        }

        public void Init(List<Customer> newList)
        {
            _customers = newList;
        }

        public void Clear()
        {
            _customers.Clear();
        }

        public Customer WhoIsNext()
        {
            return _customers[0];
        }

        public int count()
        {
            return _customers.Count;
        }

        public void SortByProtection()
        {
            _customers.Sort(new SortByProtection());
        }

        public void SortByTotalPurchases()
        {
            _customers.Sort(new SortByTotalPurchases());
        }

        public void SortByBirthYear()
        {
            _customers.Sort(new SortByBirthYear());
        }

        public List<Customer> DequeueCustomer(int ind)
        {
            if (_customers.Count > 0)
            {
                List<Customer> result = new List<Customer>();
                for (int i = 0; i < ind; i++)
                {
                    result[i] = _customers[i];
                    _customers.RemoveAt(i);
                }
                return result;
            }
            return null;
        }

        public void AniRakSheela(Customer customer)
        {
            
        }
    }
}
