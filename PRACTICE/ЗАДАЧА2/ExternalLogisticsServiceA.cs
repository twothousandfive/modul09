namespace PRACTICE.ЗАДАЧА2;

public class ExternalLogisticsServiceA
{
    public void ShipItem(int itemId)
    {
        // Логика отправки товара внешним сервисом A
    }

    public void TrackShipment(int shipmentId)
    {
        // Логика отслеживания отправки
    }
}
public class ExternalLogisticsServiceB
{
    public void SendPackage(string packageInfo)
    {
        // Логика отправки посылки внешним сервисом B
    }

    public string CheckPackageStatus(string trackingCode)
    {
        // Логика проверки статуса посылки
        return "Delivered";
    }
}