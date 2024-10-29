namespace HOMEWORK.ЗАДАЧА2;

public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}
public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount} via PayPal");
    }
}

public class StripePaymentService
{
    public void MakeTransaction(double totalAmount)
    {
        Console.WriteLine($"Processing payment of {totalAmount} via Stripe");
    }
}