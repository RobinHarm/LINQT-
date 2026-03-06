using LINQ_Töö.models;

namespace LINQ_Töö
{
    class ProductData
    {
        public static readonly List<ProductList> products = new List<ProductList>
        {
         new ProductList()
         {
             Id = 1,
             Name = "Piim",
             Category = "Piimatoode",
             Price = 0.99,
             Amount = 120
         },
         new ProductList()
         {
             Id = 2,
             Name = "Tolmuimeja",
             Category = "Kodutoode",
             Price = 129.00,
             Amount = 113
         },
         new ProductList()
         {
             Id = 3,
             Name = "Coca-Cola",
             Category = "Jook",
             Price = 2.35,
             Amount = 25
         },
         new ProductList()
         {
             Id = 4,
             Name = "Fanta",
             Category = "Võlujook",
             Price = 2.35,
             Amount = 18
         },
         new ProductList()
         {
             Id = 5,
             Name = "Pulgakomm",
             Category = "Kommitoode",
             Price = 0.20,
             Amount = 20
         },
         new ProductList()
         {
             Id = 6,
             Name = "Pesumasin",
             Category = "Riidepesutoode",
             Price = 250.99,
             Amount = 53
         },
         new ProductList()
         {
             Id = 7,
             Name = "Voodilina",
             Category = "Magamistoode",
             Price = 25.99,
             Amount = 200
         },
         new ProductList()
         {
             Id = 8,
             Name = "Padjapüür",
             Category = "Heaunetoode",
             Price = 19.99,
             Amount = 11
         },
         new ProductList()
         {
             Id = 9,
             Name = "Prügikast",
             Category = "Haisevtoode",
             Price = 4.99,
             Amount = 10
         },
         new ProductList()
         {
             Id = 10,
             Name = "Makaroonid",
             Category = "Söömistoode",
             Price = 1.24,
             Amount = 999
         },
        };
    }
}
