using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    abstract class Product
    {
        abstract public string ItemName { get; protected set; }
        public int Id { get; protected set; }
        protected static int _countId = 0;

        public Product()
        {
            Id = ++_countId;
        }
    }
}
