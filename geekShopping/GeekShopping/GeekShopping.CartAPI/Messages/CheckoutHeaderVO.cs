﻿using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.MessageBus;

namespace GeekShopping.CartAPI.Messages {
    public class CheckoutHeaderVO : BaseMessage {

        public string UserId { get; set; }

        public string? CouponCode { get; set; }

        public double PurchaseAmount { get; set; }

        public double DiscountAmount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateTime { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string CardNumber { get; set; }

        public string CVV { get; set; }

        public string ExpiryMonthYear { get; set; }

        public int CartTotalItens { get; set; }

        public IEnumerable<CartDetailVO>? CartDetails { get; set; }
    }
}
