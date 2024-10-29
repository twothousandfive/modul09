namespace HOMEWORK.ЗАДАЧА1;

public interface IBeverage
{
    string GetDescription();
    double Cost();
}
public abstract class Beverage : IBeverage
{
    public abstract string GetDescription();
    public abstract double Cost();
}

public abstract class BeverageDecorator : Beverage
{
    protected IBeverage beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription();
    }

    public override double Cost()
    {
        return beverage.Cost();   

    }
}