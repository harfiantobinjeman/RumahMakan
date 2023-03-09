using AutoMapper;
using RUmahMakan.Contrak.Dto.Product;
using RUmahMakan.Domain.Model;

namespace RumahMakan.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap();
            CreateMap<Product, ProductForCreateDto>()
                .ReverseMap();

        }
    }
}
