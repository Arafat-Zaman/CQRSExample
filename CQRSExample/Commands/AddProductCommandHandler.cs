using CQRSExample.Models;
using CQRSExample.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.Commands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public AddProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            await _repository.AddProductAsync(product);
            return product.Id;
        }
    }
}
