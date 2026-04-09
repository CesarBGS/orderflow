using MediatR;

namespace Application.UseCases.Orders.Commands;

public record CreateOrderCommand(string CustomerName) : IRequest<Guid>;