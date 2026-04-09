using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Orders.Commands;

public class AddOrderItemHandler : IRequestHandler<AddOrderItemCommand, Unit>
{
    private readonly IOrderRepository _repository;

    public AddOrderItemHandler(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(AddOrderItemCommand request, CancellationToken cancellationToken)
    {
        var order = await _repository.GetByIdAsync(request.OrderId);

        if (order is null)
            throw new Exception("Pedido não encontrado");

        order.AddItem(request.ProductId, request.ProductName, request.UnitPrice, request.Quantity);

        await _repository.UpdateAsync(order);

        return Unit.Value;
    }
}