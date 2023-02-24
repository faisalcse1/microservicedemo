using Discount.API.Models;

namespace Discount.API.Repository
{
    public interface ICouponRepositroy
    {
        Task<Coupon> GetDiscount(string productId);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productId);
    }
}
