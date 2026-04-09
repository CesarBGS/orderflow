using Domain.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Orders.Commands;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    private readonly IOrderRepository _repository;

    public CreateOrderHandler(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order(request.CustomerName);
        await _repository.AddAsync(order);
        return order.Id;
    }
  
}