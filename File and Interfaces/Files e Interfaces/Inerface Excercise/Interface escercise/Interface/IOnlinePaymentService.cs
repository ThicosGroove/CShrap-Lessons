namespace Interface_escercise.Interface
{
    interface IOnlinePaymentService
    {
        float PaymentFee(float amount);

        float Interest(float amount, int months);
    }
}
