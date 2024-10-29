namespace PRACTICE.ЗАДАЧА2;

public class LogisticsAdapterA : IInternalDeliveryService
{
    private ExternalLogisticsServiceA _serviceA;

    public LogisticsAdapterA(ExternalLogisticsServiceA serviceA)
    {
        _serviceA = serviceA;
    }

    public void DeliverOrder(string orderId)
    {
        // Преобразование вызова к методу внешней службы
        _serviceA.ShipItem(int.Parse(orderId));
    }

    public string GetDeliveryStatus(string orderId)
    {
        // Преобразование вызова к методу внешней службы
        _serviceA.TrackShipment(int.Parse(orderId));
        return "In transit"; // Или получить реальный статус от внешней службы
    }
}

public class LogisticsAdapterB : IInternalDeliveryService
{
    private ExternalLogisticsServiceB _serviceB;

    public LogisticsAdapterB(ExternalLogisticsServiceB serviceB)
    {
        _serviceB = serviceB;
    }

    public void DeliverOrder(string orderId)
    {
        // Преобразование вызова к методу внешней службы
        string packageInfo = $"Order {orderId}"; // Пример преобразования, может потребоваться более сложная логика
        _serviceB.SendPackage(packageInfo);
    }

    public string GetDeliveryStatus(string orderId)
    {
        // Преобразование вызова к методу внешней службы
        string trackingCode = GetTrackingCodeFromOrderId(orderId); // Логика получения трекинг-кода
        return _serviceB.CheckPackageStatus(trackingCode);
    }

    private string GetTrackingCodeFromOrderId(string orderId)
    {
        return "trackingCode_" + orderId; // Пример упрощенной реализации
    }
}