﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExcer01
{
    class Item
    {
        public int Number { get; set; }
        public string Date { get; set; }
        public string Sku { get; set; }
        public string Item_Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        static List<Item> _items = new List<Item>();

        public void save()
        {
            _items.Add(this);
            Console.WriteLine("Saved into the List(_items) Successfully");
        }
      static public List<Item> Getallproducts()
        {
            return _items;
        }

    }

}
