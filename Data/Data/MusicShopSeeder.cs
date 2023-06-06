using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public static class MusicShopSeeder
    {
        public static List<Music_Shop.Models.Guitar> GetGuitars()
        {
            return new List<Music_Shop.Models.Guitar>()
            {
                new Music_Shop.Models.Guitar()
                {
                    Id = 1,
                    Name = "Yamaha F310",
                    Type = "Western",
                    Color = "White",
                    Price = 340,
                    ExtraProductsId = 11,
                    ImagePath = @"https://www.muztorg.ru/files/1dd/71t/qsp/928/gsw/4cw/soo/88c/c/1dd71tqsp928gsw4cwsoo88cc.jpg"
                },
                new Music_Shop.Models.Guitar()
                {
                    Id = 2,
                    Name = "Rockdale Aurora D1",
                    Type = "Dreadnought",
                    Color = "Black",
                    Price = 130,
                    ExtraProductsId = 6,
                    ImagePath = @"https://www.muztorg.ru/files/1le/qe7/pgx/f6s/0s0/w40/og4/84s/w/1leqe7pgxf6s0s0w40og484sw.jpg"
                },
                new Music_Shop.Models.Guitar()
                {
                    Id = 3,
                    Name = "Crafter D-7",
                    Type = "Dreadnought",
                    Color = "Brown",
                    Price = 600,
                    ExtraProductsId = 8,
                    ImagePath = @"https://www.muztorg.ru/files/1rt/y8s/dbm/vhc/ks4/swg/4s4/o88/8/1rty8sdbmvhcks4swg4s4o888.jpeg"
                },
                new Music_Shop.Models.Guitar()
                {
                    Id = 4,
                    Name = "Fender CD",
                    Type = "Dreadnought",
                    Color = "Natural",
                    Price = 790,
                    ExtraProductsId = 2,
                    ImagePath = @"https://www.muztorg.ru/files/2rp/kok/xui/58g/gcw/04k/484/cg0/k/2rpkokxui58ggcw04k484cg0k.jpg"
                }
            };
        }
        public static Music_Shop.Models.Guitar GetGuitarById(int id)
        {
            return GetGuitars().FirstOrDefault(g => g.Id == id);
        }

        public static List<Models.ExtraProduct> GetExtraProduct()
        {
            return new List<Models.ExtraProduct>()
            {
                    new Models.ExtraProduct
                    {
                        Id = 1,
                        Name = "Extra strings"
                    },
                     new Models.ExtraProduct
                    {
                        Id = 2,
                        Name = "Pack of mediators (5 pieces)"
                    },
                      new Models.ExtraProduct
                    {
                        Id = 3,
                        Name = "Pack of mediators (15 pieces)"
                    },
                       new Models.ExtraProduct
                    {
                        Id = 4,
                        Name = "Extra strings + pack of mediators (5 pieces)"
                    },
                        new Models.ExtraProduct
                    {
                        Id = 5,
                        Name = "Extra strings + pack of mediators (15 pieces)"
                    },
                        new Models.ExtraProduct
                    {
                        Id = 6,
                        Name = "2 packs of extra strings"
                    },
                        new Models.ExtraProduct
                    {
                        Id = 7,
                        Name = "5 packs of extra strings"
                    },
                        new Models.ExtraProduct
                    {
                        Id = 8,
                        Name = "2 packs of extra strings + pack of mediators (5 pieces)"
                    },
                         new Models.ExtraProduct
                    {
                        Id = 9,
                        Name = "2 packs of extra strings + pack of mediators (15 pieces)"
                    },
                          new Models.ExtraProduct
                    {
                        Id = 10,
                        Name = "5 packs of extra strings + pack of mediators (5 pieces)"
                    },
                           new Models.ExtraProduct
                    {
                        Id = 11,
                        Name = "5 packs of extra strings + pack of mediators (15 pieces)"
                    },

            };
        }
    }
}
