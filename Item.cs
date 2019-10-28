using System;
using System.Collections.Generic;
using System.Text;

namespace KnapsackGA
{
    class Item
    {
        public int weight { get; set; }
        public int value{ get; set; }

        public Item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
        }
    }

    
}
