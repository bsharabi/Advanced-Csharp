using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dictionary_of_objects
{
    class Food
    {
        public decimal Price { get; set; }
        public bool IsVeg { get; set; }


        public string GetDesc()
        {
            return $"Price: {Price}, IsVeg : {IsVeg}";
        }
    }
}
