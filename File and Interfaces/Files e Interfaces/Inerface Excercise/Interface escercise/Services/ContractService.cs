using System;
using System.Collections.Generic;
using System.Text;
using Interface_escercise.Entities;
using Interface_escercise.Interface;

namespace Interface_escercise.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            float basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++) 
            {
                DateTime date = contract.Date.AddMonths(i);
                float updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                float fullQuota =  updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
