
using AutoMapper;
using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.DTOs.Identity;
using eCommerceApp.Application.DTOs.Product;
using eCommerceApp.Domain;
using eCommerceApp.Domain.Entities.Identity;
namespace eCommerceApp.Application.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateCategory, Category>();
            CreateMap<CreateProduct, Product>();
            CreateMap<Category, GetCategory>();
            CreateMap<Product, GetProduct>();
            CreateMap<CreateUser, AppUser>();
            CreateMap<LoginUser, AppUser>();
        }
    }
}