using PRACTICE.ЗАДАЧА2;
class Program
{
    static void Main(string[] args)
    {
        DeliveryServiceFactory factory = new DeliveryServiceFactory();

        // Использование внутренней службы
        IInternalDeliveryService internalService = factory.GetDeliveryService("internal");
        internalService.DeliverOrder("123");

        // Использование внешней службы A
        IInternalDeliveryService externalServiceA = factory.GetDeliveryService("externalA");
        externalServiceA.DeliverOrder("456");
    }
}