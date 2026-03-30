using ProductClientHub.API.Infraestructure;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Clients.GetAll
{
    public class GetAllClientsUseCase
    {
        public ResponseAllClientsJson Execute()
        {
            var dbContext = new ProductClientHubDbContext();

            var clients = dbContext.Clients.ToList();

            return new ResponseAllClientsJson
            {
                Clients = clients.Select(clients => new ResponseShortClientJson
                {
                    Id = clients.id,
                    Name = clients.Name,
                }).ToList()
            };
        }
    }
}
