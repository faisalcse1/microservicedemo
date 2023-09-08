using AutoMapper;
using Ordering.Application.Features.Orders.Commands.CreateOrder;
using Ordering.Application.Features.Orders.Commands.UpdateOrder;
using Ordering.Application.Features.Orders.Queries.GetOrdersByUserName;
using Ordering.Domain.Models;

namespace Ordering.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderVm>().ReverseMap();            
            CreateMap<Order, CreateOrderCommand>().ReverseMap();            
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();            
        }
    }
}
