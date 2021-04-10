using System;
using System.Collections.Generic;
using System.Text;

namespace Store_system_list.Store
{
    public class Sales
    {
        public Products Products;
        public Clients Clients;
        public int Amount;

        public float totalAmount()
        {
            return Amount;
        }

    }
}
