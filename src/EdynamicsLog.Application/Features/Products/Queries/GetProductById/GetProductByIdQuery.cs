﻿using EdynamicsLog.Application.Exceptions;
using EdynamicsLog.Application.Interfaces.Repositories;
using EdynamicsLog.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
        {
            private readonly IProductRepositoryAsync _productRepository;

            public GetProductByIdQueryHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;               
            }

            public async Task<Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(query.Id);
                if (product == null) throw new ApiException($"Product Not Found.");
                return product;
            }
        }
    }
}
