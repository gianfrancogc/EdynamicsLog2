using AutoMapper;
using EdynamicsLog.Application.Features.Products.Queries.GetAllProductsBySearch;
using EdynamicsLog.Application.Interfaces.Repositories;
using EdynamicsLog.Application.Wrappers;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Features.Products.Queries.GetAllProductsByCategorySearch
{
    public class GetAllProductsSearchCategoryQuery : IRequest<PagedResponse<IEnumerable<GetAllProductsSearchCategoryViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int IdCategory { get; set; }
    }
    public class GetAllProductsSearchCategoryQueryHandler : IRequestHandler<GetAllProductsSearchCategoryQuery, PagedResponse<IEnumerable<GetAllProductsSearchCategoryViewModel>>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public GetAllProductsSearchCategoryQueryHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllProductsSearchCategoryViewModel>>> Handle(GetAllProductsSearchCategoryQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllProductsSearchCategoryParameter>(request);
            var product = await _productRepository.GetPagedReponseSearchByCategoryAsync(request.IdCategory, validFilter.PageNumber, validFilter.PageSize);
            var productViewModel = _mapper.Map<IEnumerable<GetAllProductsSearchCategoryViewModel>>(product);
            return new PagedResponse<IEnumerable<GetAllProductsSearchCategoryViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
