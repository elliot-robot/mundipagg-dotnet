namespace Mundipagg.Models.Request
{
    public class UpdateChargePaymentMethodRequest
    {
        public CreateBoletoPaymentRequest Boleto { get; set; }

        public CreateCreditCardPaymentRequest CreditCard { get; set; }

        public CreateDebitCardPaymentRequest DebitCard { get; set; }

        public string PaymentMethod { get; set; }

        public bool UpdateSubscription { get; set; }

        public CreateVoucherPaymentRequest Voucher { get; set; }
    }
}