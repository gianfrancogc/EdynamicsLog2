using AutoMapper;
using EdynamicsLog.Application.DTOs.Account;
using EdynamicsLog.Application.DTOs.Product;
using EdynamicsLog.Application.Features.Products.Commands.CreateProduct;
using EdynamicsLog.Application.Features.Products.Queries.GetAllProducts;
using EdynamicsLog.Application.Features.Products.Queries.GetAllProductsByCategorySearch;
using EdynamicsLog.Application.Features.Products.Queries.GetAllProductsBySearch;
using EdynamicsLog.Domain.Entities;

namespace EdynamicsLog.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            CreateMap<GetAllProductsSearchQuery, GetAllProductsCategorySearchParameter>().ReverseMap();
            CreateMap<Product, GetAllProductsSearchViewModel>().ReverseMap();
            CreateMap<ProductSingleResponseDto, Product>().ReverseMap();
            CreateMap<GetAllProductsSearchCategoryQuery, GetAllProductsSearchCategoryParameter>().ReverseMap();
            CreateMap<Product, GetAllProductsSearchCategoryViewModel>().ReverseMap();
            CreateMap<Product, UserSingleResponse>().ReverseMap();
        }
    }
}
