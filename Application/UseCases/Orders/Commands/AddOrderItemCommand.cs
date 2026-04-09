using MediatR;

namespace Application.UseCases.Orders.Commands;

public record AddOrderItemCommand(
    Guid OrderId,
    Guid ProductId,
    string ProductName,
    decimal UnitPrice,
    int Quantity) : IRequest<Unit>;