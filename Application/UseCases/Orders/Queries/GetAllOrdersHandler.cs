using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Orders.Queries;

public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, IEnumerable<Order>>
{
    private readonly IOrderRepository _repository;

    public GetAllOrdersHandler(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}