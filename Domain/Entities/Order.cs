namespace Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public string CustomerName { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public decimal Total => _items.Sum(i => i.Subtotal);

    private readonly List<OrderItem> _items = new();
    public IReadOnlyList<OrderItem> Items => _items;

    public Order(string customerName)
    {
        Id = Guid.NewGuid();
        CustomerName = customerName;
        CreatedAt = DateTime.UtcNow;
    }

    public void AddItem(Guid productId, string productName, decimal unitPrice, int quantity)
    {
        var item = new OrderItem(Id, productId, productName, unitPrice, quantity);
        _items.Add(item);
    }
}