using Discount.Grpc.Models;

namespace Discount.Grpc.Repository
{
    public interface ICouponRepositroy
    {
        Task<Coupon> GetDiscount(string productId);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productId);
    }
}
