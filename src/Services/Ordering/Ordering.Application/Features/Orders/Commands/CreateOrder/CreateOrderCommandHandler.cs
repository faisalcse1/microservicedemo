using AutoMapper;
using MediatR;
using Ordering.Application.Contacts.Infrastructure;
using Ordering.Application.Contacts.Persistence;
using Ordering.Application.Models;
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
        IEmailService _emailService;
        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IEmailService emailService)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _emailService = emailService;
        }
        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request);
            bool isOrderPlaced = await _orderRepository.AddAsync(order);
            if (isOrderPlaced)
            {
                Email email = new Email();
                email.Subject = "Your Order has been placed.";
                email.To = order.UserName;
                email.Body = $"Dear {order.FirstName + " " + order.LastName} <br/><br/> We are excited for you to received your order #{order.Id} and with notify you one it's way. <br/> Thank you for ordering form Programming Palli.";
                await _emailService.SendEmailAsync(email);
            }
            return isOrderPlaced;
        }
    }
}
