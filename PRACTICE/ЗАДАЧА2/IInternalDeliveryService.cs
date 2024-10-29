namespace PRACTICE.ЗАДАЧА2;

public interface IInternalDeliveryService
{
    void DeliverOrder(string orderId);
    string GetDeliveryStatus(string orderId);
}
public class InternalDeliveryService : IInternalDeliveryService
{
    public void DeliverOrder(string orderId)
    {
        // Логика доставки внутренним сервисом
        Console.WriteLine($"Delivering order {orderId} internally");
    }

    public string GetDeliveryStatus(string orderId)
    {
        // Логика получения статуса доставки
        return "In transit";
    }
}