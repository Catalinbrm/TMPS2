using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IShoesRepository
    {
        Shoes GetShoesById(int id);
        void InsertShoes(Shoes shoes);
        void RemoveShoesById(int id);
    }
}
