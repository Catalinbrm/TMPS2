using Proxy;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoesRepository repo = new ShoesCachedRepository(new ShoesRepository());

            var shoes1 = repo.GetShoesById(2);
            var shoes2 = repo.GetShoesById(5);
            var shoes3 = repo.GetShoesById(4);
            var shoes4 = repo.GetShoesById(1);

        }
    }
}
