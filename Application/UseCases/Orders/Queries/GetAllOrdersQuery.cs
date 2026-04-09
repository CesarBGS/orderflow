using MediatR;
using Domain.Entities;

namespace Application.UseCases.Orders.Queries;

public record GetAllOrdersQuery() : IRequest<IEnumerable<Order>>;