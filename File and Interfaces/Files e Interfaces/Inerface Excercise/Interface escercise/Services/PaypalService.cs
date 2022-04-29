using System;
using System.Collections.Generic;
using System.Text;
using Interface_escercise.Interface;

namespace Interface_escercise.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const float FeePercentage = 0.02f;
        private const float MonthlyInterest = 0.01f;


        public float Interest(float amount, int months) 
        {
            return amount * MonthlyInterest * months;
        }
        public float PaymentFee(float amount) 
        {
            return amount * FeePercentage;
        }
    }
}
