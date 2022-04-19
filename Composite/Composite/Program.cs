using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder BRAND = new Folder("BRAND");

            Brand clothes_brand1 = new Brand("BOSS");
            Brand clothes_brand2 = new Brand("LEVI'S");
            Brand clothes_brand3 = new Brand("GUESS");
            Folder CLOTHES = new Folder("CLOTHES");

            Brand shoes_brand1 = new Brand("NIKE");
            Brand shoes_brand2 = new Brand("PUMA");
            Brand shoes_brand3 = new Brand("ADIDAS");
            Folder SHOES = new Folder("SHOES");

            CLOTHES.AddComponent(clothes_brand1);
            CLOTHES.AddComponent(clothes_brand2);
            CLOTHES.AddComponent(clothes_brand3);
            BRAND.AddComponent(CLOTHES);

            SHOES.AddComponent(shoes_brand1);
            SHOES.AddComponent(shoes_brand2);
            SHOES.AddComponent(shoes_brand3);
            BRAND.AddComponent(SHOES);

            BRAND.Display();

            
        }
    }
}
