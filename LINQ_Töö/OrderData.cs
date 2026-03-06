using LINQ_Töö.models;

namespace LINQ_Töö
{
    class OrderData
    {
        public static readonly List<OrderList> orders = new List<OrderList>
        {
            new OrderList()
            {
             Id = 1,
             ClientId = 1,
             ProductId = 1,
             Amount = 3,
            },
            new OrderList()
            {
                Id = 2,
             ClientId = 2,
             ProductId = 2,
             Amount = 2,
            },
            new OrderList()
            {
                Id = 3,
             ClientId = 3,
             ProductId = 3,
             Amount = 1,
            },
            new OrderList()
            {
                Id = 4,
             ClientId = 4,
             ProductId = 4,
             Amount = 6,
            },
            new OrderList()
            {
                Id = 5,
             ClientId = 5,
             ProductId = 5,
             Amount = 5,
            },
            new OrderList()
            {
                Id = 6,
             ClientId = 6,
             ProductId = 6,
             Amount = 4,
            },
            new OrderList()
            {
             Id = 7,
             ClientId = 7,
             ProductId = 7,
             Amount = 8,
            },
            new OrderList()
            {
                Id = 8,
             ClientId = 8,
             ProductId = 8,
             Amount = 7,
            },
            new OrderList()
            {
              Id = 9,
             ClientId = 9,
             ProductId = 9,
             Amount = 9,
            },
            new OrderList()
            {
              Id = 10,
             ClientId = 10,
             ProductId = 10,
             Amount = 10,
            },
        };
    }
}
