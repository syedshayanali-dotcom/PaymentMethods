

public abstract class PaymentMethodClass
{
    public abstract string ProcessPayment(decimal amount, string customerName);
}
public class CreditCardPayment: PaymentMethodClass
{
    public override string ProcessPayment(decimal amount,string customerName)
    {

       return "Processing Credit Card Payment of Amount is:" + amount + " ,Customer Name is:" + customerName;

    }
}
public class PayPalPayment:PaymentMethodClass
{
    public override string ProcessPayment(decimal amount, string customerName)
    {

        return "Processing PayPal Payment of Amount is:" + amount + " ,Customer Name is:" + customerName;

    }
}
public class BankTransferPayment : PaymentMethodClass
{
    public override string ProcessPayment(decimal amount, string customerName)
    {

        return "Process Bank Transfer Payment of Amount is:" + amount + " ,Customer Name is:" + customerName;

    }
}


public class Program
{
    public static void Main(string[] args)
    {
        List<PaymentMethodClass> paymentMethods = new List<PaymentMethodClass>
        {
        new CreditCardPayment(),
        new PayPalPayment(),
        new BankTransferPayment()

        };


        decimal amount = 50000.00m;
        string customerName = "Ali";


        foreach (var methods in paymentMethods)
        {
            Console.WriteLine(methods.ProcessPayment(amount, customerName));
        }

    }
}