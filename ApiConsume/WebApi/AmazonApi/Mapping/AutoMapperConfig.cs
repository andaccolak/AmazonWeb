using AutoMapper;
using DtoLayer.Dtos;
using Entity.Concrete;

namespace AmazonApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddOrderDto, Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();
        }
    }
}
