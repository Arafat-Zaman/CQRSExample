using CQRSExample.Models;
using CQRSExample.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetProductByIdAsync(request.Id);
        }
    }
}
