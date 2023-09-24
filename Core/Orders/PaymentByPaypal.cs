﻿namespace GalliumPlus.WebApi.Core.Orders
{
    public class PaymentByPaypal : PaymentMethod
    {
        public override string Description => "PayPal";

        protected override string ProcessPayment(decimal _) => "OK";
    }
}
