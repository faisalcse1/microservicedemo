using AutoMapper;
using EventBus.Messages.Events;
using Ordering.Application.Features.Orders.Commands.CreateOrder;

namespace Ordering.API.Maping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<BasketCheckoutEvent, CreateOrderCommand>().ReverseMap();
        }
    }
}
