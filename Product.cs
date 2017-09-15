using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsAutmnWinter
{
    abstract class Product
    {
        public int weight;
        
        public Product(int weight)
        {
            this.weight = weight;
        }
    }
}
