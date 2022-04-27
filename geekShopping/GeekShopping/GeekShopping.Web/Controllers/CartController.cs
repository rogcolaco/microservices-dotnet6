using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers {
    public class CartController : Controller {

        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly ICouponService _couponService;

        public CartController(IProductService productService, ICartService cartService, ICouponService couponService) {
            _productService = productService;
            _cartService = cartService;
            _couponService = couponService;
        }

        [Authorize]
        public async Task<IActionResult> CartIndex() {

            return View(await FindUserCart());
        }

        [HttpPost]
        [ActionName("ApplyCoupon")]
        public async Task<IActionResult> ApplyCoupon(CartViewModel model) {

            var token = await HttpContext.GetTokenAsync("access_token");
            var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
            var cartResponse = await _cartService.FindCartByUserId(userId, token);
            cartResponse.CartHeader.CouponCode = model.CartHeader.CouponCode;
            if (string.IsNullOrEmpty(cartResponse.CartHeader.CouponCode)) {
                return RedirectToAction(nameof(CartIndex));
            }
            var response = await _cartService.ApplyCoupon(cartResponse, token);

            if (response) {
                return RedirectToAction(nameof(CartIndex));
            }

            return View();
        }

        [HttpPost]
        [ActionName("RemoveCoupon")]
        public async Task<IActionResult> RemoveCoupon() {

            var token = await HttpContext.GetTokenAsync("access_token");
            var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
            var response = await _cartService.RemoveCoupon(userId, token);

            if (response) {
                return RedirectToAction(nameof(CartIndex));
            }

            return View();
        }

        public async Task<IActionResult> Remove(int id) {
            var token = await HttpContext.GetTokenAsync("access_token");
            var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
            var response = await _cartService.RemoveFromCart(id, token);

            if (response) {
                return RedirectToAction(nameof(CartIndex));
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Checkout() {

            return View(await FindUserCart());
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CartViewModel model) {
            var token = await HttpContext.GetTokenAsync("access_token");

            //CartHeaderVO--------------------------
            var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
            var cartResponse = await _cartService.FindCartByUserId(userId, token);
            CheckoutViewModel checkoutViewModel = new CheckoutViewModel {
                Id = model.CartHeader.Id,
                UserId = model.CartHeader.UserId,
                CouponCode = model.CartHeader.CouponCode,
                PurchaseAmount = model.CartHeader.PurchaseAmount,
                DiscountAmount = model.CartHeader.DiscountAmount,
                FirstName = model.CartHeader.FirstName,
                LastName = model.CartHeader.LastName,
                DateTime = model.CartHeader.DateTime,
                Phone = model.CartHeader.Phone,
                Email = model.CartHeader.Email,
                CardNumber = model.CartHeader.CardNumber,
                CVV = model.CartHeader.CVV,
                ExpiryMonthYear = model.CartHeader.ExpiryMonthYear,
                CartTotalItens = cartResponse.CartDetails.Count(),
                CartDetails = cartResponse.CartDetails,
            };
            //---------------------------

            var response = await _cartService.Checkout(checkoutViewModel, token);

            if (response != null) {
                return RedirectToAction(nameof(Confirmation));
            }
            return View(checkoutViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Confirmation() {
            return View();
        }

        private async Task<CartViewModel> FindUserCart() {
            var token = await HttpContext.GetTokenAsync("access_token");
            var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;
            var response = await _cartService.FindCartByUserId(userId, token);

            if (response?.CartHeader != null) {
                if (!string.IsNullOrEmpty(response.CartHeader.CouponCode)) {
                    var coupon = await _couponService.GetCoupon(response.CartHeader.CouponCode, token);
                    if (coupon?.CouponCode != null) {
                        response.CartHeader.DiscountAmount = coupon.DiscountAmount;
                    }
                }
                foreach (var detail in response.CartDetails) {
                    response.CartHeader.PurchaseAmount += (detail.Product.Price * detail.Count);
                }
                    response.CartHeader.PurchaseAmount -= response.CartHeader.DiscountAmount;
            }
            return response;
        }
    }
}


