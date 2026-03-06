using LINQ_Töö.models;

namespace LINQ_Töö
{
    class ClientData
    {
        public static readonly List<ClientList> clients = new List<ClientList>
        {
            new ClientList()
        {
            Id = 1,
                 Name = "Richard",
                 City = "Tallinn"
            },
            new ClientList()
        {
            Id = 2,
                 Name = "Karl",
                 City = "Tartu",
            },
            new ClientList()
        {
            Id = 3,
                 Name = "Toomas",
                 City = "Lasnamäe"
            },
            new ClientList()
            {
                 Id = 4,
                 Name = "Mairon",
                 City = "Mustamägi"
            },
            new ClientList()
            {
                Id = 5,
                Name = "Simon",
                City = "Narva"
            },
        };
    }    
}    

