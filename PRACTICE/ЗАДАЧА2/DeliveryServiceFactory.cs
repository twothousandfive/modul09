namespace PRACTICE.ЗАДАЧА2;

public class DeliveryServiceFactory
{
    public IInternalDeliveryService GetDeliveryService(string serviceType)
    {
        switch (serviceType)
        {
            case "internal":
                return new InternalDeliveryService();
            case "externalA":
                return new LogisticsAdapterA(new ExternalLogisticsServiceA());
            case "externalB":
                return new LogisticsAdapterB(new ExternalLogisticsServiceB());
            default:
                throw new ArgumentException("Unknown service type");
        }
    }
}