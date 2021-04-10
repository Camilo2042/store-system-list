using System;
using System.Collections.Generic;
using System.Text;

namespace Store_system_list.Store
{
    public class Products
    {
        public string name;
        public float price;
        public int amount;

        public float totalSales()
        {
            return price;
        }

    }

}
