namespace HOMEWORK.ЗАДАЧА2;

public class StripePaymentAdapter
{
    private readonly StripePaymentService _stripePaymentService;

    public StripePaymentAdapter(StripePaymentService stripePaymentService)
    {
        _stripePaymentService = stripePaymentService;
    }

    public void ProcessPayment(double amount)
    {
        _stripePaymentService.MakeTransaction(amount);
    }
}