using AutoMapper;
using EdynamicsLog.Application.Interfaces.Repositories;
using EdynamicsLog.Application.Wrappers;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Features.Products.Queries.GetAllProductsBySearch
{
    public class GetAllProductsSearchQuery : IRequest<PagedResponse<IEnumerable<GetAllProductsSearchViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
    }
    public class GetAllProductsSearchQueryHandler : IRequestHandler<GetAllProductsSearchQuery, PagedResponse<IEnumerable<GetAllProductsSearchViewModel>>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public GetAllProductsSearchQueryHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllProductsSearchViewModel>>> Handle(GetAllProductsSearchQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllProductsCategorySearchParameter>(request);
            var product = await _productRepository.GetPagedReponseSearchAsync(validFilter.PageNumber, validFilter.PageSize, request.Search);
            var productViewModel = _mapper.Map<IEnumerable<GetAllProductsSearchViewModel>>(product);
            return new PagedResponse<IEnumerable<GetAllProductsSearchViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
