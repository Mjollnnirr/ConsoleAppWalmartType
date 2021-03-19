using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Electronic : Product, IAccessibility
    {
        public double PricePerCount { get; set; }
        public int ProductCount = 0;

        public bool Availablty()
        {
            if (ProductCount > 0)
            {
                return true;
            }
            return false;
        }
    }
}
