namespace HOMEWORK.ЗАДАЧА1;

public class Espresso : Beverage
{
    public override string GetDescription()
    {
        return "Espresso";
    }

    public override double Cost()
    {
        return 1.99;
    }    
}
public class Milk : BeverageDecorator
{
    public Milk(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }

    public override   
        double Cost()
    {
        return beverage.Cost()   
               + 0.50;
    }
}

public class Sugar : BeverageDecorator
{
    public Sugar(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Sugar";
    }

    public override double Cost()
    {
        return beverage.Cost()   
               + 0.25;
    }
}