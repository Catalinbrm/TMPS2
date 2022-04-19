using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Shoes
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public Shoes()
        {

        }

        public Shoes(int id, string brand, string model)
        {
            Id = id;
            Brand = brand;
            Model = model;
        }
    }
}
