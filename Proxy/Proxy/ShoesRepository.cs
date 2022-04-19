using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class ShoesRepository : IShoesRepository
    {
        private readonly List<Shoes> _dbShoes = new List<Shoes>()
        {
            new Shoes(1, "Nike", "Air Zoom Pegasus 39"),
            new Shoes(2, "Nike", "Air Force 1 Crater Flyknit Next Nature"),
            new Shoes(3, "Adidas", "RACER TR21"),
            new Shoes(4, "Adidas", "DAILY 3.0"),
            new Shoes(5, "Reebok", "Club C 85 Vintage"),
            new Shoes(6, "Reebok", "Pump Omni Zone II Men's Basketball"),
        };

        public Shoes GetShoesById(int id)
        {
            Console.WriteLine("Getting shoes by id");
            Thread.Sleep(2000);

            return _dbShoes.FirstOrDefault(x => x.Id == id);
        }

        public void InsertShoes(Shoes shoes)
        {
            Console.WriteLine("Adding shoes");
            Thread.Sleep(2000);

            _dbShoes.Add(shoes);
        }

        public void RemoveShoesById(int id)
        {
            Console.WriteLine("Removing shoes");
            Thread.Sleep(2000);

            var shoes = _dbShoes.Find(x => x.Id == id);
            _dbShoes.Remove(shoes);
        }
    }
}
