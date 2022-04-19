using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ShoesCachedRepository : IShoesRepository
    {
        private readonly ShoesRepository _dbRepo;
        private readonly Dictionary<int, Shoes> _cache;

        public ShoesCachedRepository(ShoesRepository dbRepo)
        {
            _dbRepo = dbRepo;
            _cache = new Dictionary<int, Shoes>();
        }
        public Shoes GetShoesById(int id)
        {
            Shoes shoes = null;

            _cache.TryGetValue(id, out shoes);

            if (shoes == null)
            {
                shoes = _dbRepo.GetShoesById(id);
                if (shoes != null)
                    _cache.Add(shoes.Id, shoes);
            }
            else
                Console.WriteLine("Shoes extracted from cache");

            return shoes;
        }

        public void InsertShoes(Shoes shoes)
        {
            _dbRepo.InsertShoes(shoes);
            _cache.Add(shoes.Id, shoes);
        }

        public void RemoveShoesById(int id)
        {
            _dbRepo.RemoveShoesById(id);
            _cache.Remove(id);
        }
    }
}
