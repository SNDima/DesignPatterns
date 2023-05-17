namespace StrategyPattern
{
    internal class PaymentSystem
    {
        public IPaymentMethod PaymentMethod { get; set; }
        public ICheckBehaviour CheckBehaviour { get; set; }

        public PaymentSystem()
        {
            PaymentMethod = new NoPaymentMethod();
            CheckBehaviour = new NoCheckBehaviour();
        }

        public void ExecutePayment()
        {
            PaymentMethod.Pay();
            // Log payment
            // Send payment confirmation
        }

        public void ProcessCheckRequest()
        {
            CheckBehaviour.ProcessCheckRequest();
        }
    }
}
