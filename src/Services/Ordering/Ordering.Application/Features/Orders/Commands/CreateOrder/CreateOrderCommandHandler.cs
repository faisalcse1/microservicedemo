using AutoMapper;
using MediatR;
using Ordering.Application.Contacts.Infrastructure;
using Ordering.Application.Contacts.Persistence;
using Ordering.Application.Models;
using Ordering.Domain.Models;

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
            order.CreatedBy = "1";
            order.CreatedDate = DateTime.Now; 
            bool isOrderPlaced = await _orderRepository.AddAsync(order);
            if (isOrderPlaced)
            {
                EmailMessage email = new EmailMessage();
                email.Subject = "Your Order has been placed.";
                email.To = order.UserName;
                email.Body = $"Dear {order.FirstName + " " + order.LastName} <br/><br/> We are excited for you to received your order #{order.Id} and with notify you one it's way. <br/> Thank you for ordering form Programming Palli.";
                await _emailService.SendEmailAsync(email);
            }
            return isOrderPlaced;
        }
    }
}
