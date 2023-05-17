using StrategyPattern;

var paymentSystem = new PaymentSystem();

Console.WriteLine("Please select a payment method:");
Console.WriteLine("1 - Card");
Console.WriteLine("2 - PayPal");
Console.WriteLine("3 - Cryptocurancy");

var paymentMethodNumber = Console.ReadLine();
paymentSystem.PaymentMethod = GetPaymentMethod(paymentMethodNumber!);

paymentSystem.ExecutePayment();

Console.WriteLine("Do you need the check? Please enter yes or no.");

var checkStringValue = Console.ReadLine();
paymentSystem.CheckBehaviour = GetCheckBehaviour(checkStringValue!);

paymentSystem.ProcessCheckRequest();

static IPaymentMethod GetPaymentMethod(string paymentMethodNumber) =>
    paymentMethodNumber switch
    {
        "1" => new CardPaymentMethod(),
        "2" => new PayPalPaymentMethod(),
        "3" => new CryptoPaymentMethod(),
        _ => throw new Exception("Incorrect payment method entered."),
    };

static ICheckBehaviour GetCheckBehaviour(string checkStringValue) =>
    checkStringValue.ToLower() switch
    {
        "yes" => new PrintCheckBehaviour(),
        _ => new NoCheckBehaviour(),
    };