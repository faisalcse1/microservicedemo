using AutoMapper;
using Basket.API.Models;
using EventBus.Messages.Events;

namespace Basket.API.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<BasketCheckoutEvent, BasketCheckout>().ReverseMap();
        }
    }
}
