using AmazonWebUI.Dto.CreditCardDto;
using AmazonWebUI.Dto.OrderDto;
using AmazonWebUI.Dto.UserDto;
using AutoMapper;
using Entity.Concrete;

namespace AmazonWebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateCreditCardDto,CreditCard>().ReverseMap();
            CreateMap<ResultCreditCardDto,CreditCard>().ReverseMap();
            CreateMap<UpdateCreditCardDto,CreditCard>().ReverseMap();

            CreateMap<UserResultDto,User>().ReverseMap();
            CreateMap<UserUpdateDto,User>().ReverseMap();

            CreateMap<OrderCreateDto, Order>().ReverseMap();
            CreateMap<OrderResultDto, Order>().ReverseMap();
            CreateMap<OrderUpdateDto, Order>().ReverseMap();
        }
    }
}
