using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Messages {
    public class CheckoutVO {
        public CheckoutHeaderVO CartHeader { get; set; }
        public IEnumerable<CartDetailVO>? CartDetails { get; set; }
    }
}
