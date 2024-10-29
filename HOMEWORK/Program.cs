using HOMEWORK.ЗАДАЧА1;
using HOMEWORK.ЗАДАЧА2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ЗАДАЧА 1");
        IBeverage beverage = new Espresso();

        // Добавляем добавки
        beverage = new Milk(beverage);
        beverage = new Sugar(beverage);

        Console.WriteLine($"Description: {beverage.GetDescription()}");
        Console.WriteLine($"Cost: ${beverage.Cost()}");
        
        Console.WriteLine("ЗАДАЧА 2");
        IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
        StripePaymentService stripeService = new StripePaymentService();
        StripePaymentAdapter stripeProcessor = new StripePaymentAdapter(stripeService);

        // Использование обоих процессоров через единый интерфейс
        paypalProcessor.ProcessPayment(100);
        stripeProcessor.ProcessPayment(200);
    }
}