using AutoMapper;
using MediatR;
using Ordering.Application.Contacts.Persistence;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        IOrderRepository _orderRepository;
        IMapper _mapper;
        public CreateOrderCommandHandler(IOrderRepository orderRepository,IMapper mapper) 
        { 
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            return await _orderRepository.AddAsync(order);
        }
    }
}
