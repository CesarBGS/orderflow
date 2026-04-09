using MediatR;
using Domain.Entities;

namespace Application.UseCases.Orders.Queries;

public record GetOrderByIdQuery(Guid Id) : IRequest<Order?>;