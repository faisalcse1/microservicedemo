using AutoMapper;
using MediatR;
using Ordering.Application.Contacts.Persistence;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersByUserName
{
    public class GetOrdersByUserHandler : IRequestHandler<GetOrdersByUserQuery, List<OrderVm>>
    {
        IOrderRepository _orderRepository;
        IMapper _mapper;
        public GetOrdersByUserHandler(IOrderRepository orderRepository,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<List<OrderVm>> Handle(GetOrdersByUserQuery request, CancellationToken cancellationToken)
        {
            var orders=await _orderRepository.GetOrdersByUserName(request.UserName);
            return _mapper.Map<List<OrderVm>>(orders);
        }
    }
}
