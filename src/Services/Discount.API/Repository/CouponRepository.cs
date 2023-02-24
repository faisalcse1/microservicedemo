using Dapper;
using Discount.API.Models;
using Npgsql;

namespace Discount.API.Repository
{
    public class CouponRepository : ICouponRepositroy
    {
        IConfiguration _configuration;
        public CouponRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            var connection = new NpgsqlConnection(_configuration.GetConnectionString("DiscountDB"));
            var affected = await connection.ExecuteAsync("INSERT INTO Coupon(ProductId,ProductName,Description,Amount) VALUES(@ProductId,@ProductName,@Description,@Amount)", new { ProductId = coupon.ProductId, ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount });
            if (affected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteDiscount(string productId)
        {
            var connection = new NpgsqlConnection(_configuration.GetConnectionString("DiscountDB"));
            var affected = await connection.ExecuteAsync("DELETE FROM Coupon WHERE ProductId=@ProductId", new { ProductId = productId });
            if (affected > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<Coupon> GetDiscount(string productId)
        {
            var dd = _configuration.GetConnectionString("DiscountDB");
            var connection = new NpgsqlConnection(_configuration.GetConnectionString("DiscountDB"));
            var coupon = await connection.QueryFirstOrDefaultAsync<Coupon>
                ("SELECT * FROM Coupon WHERE ProductId=@ProductId", new { ProductId = productId });
            if (coupon == null)
            {
                return new Coupon() { Amount = 0, ProductName = "No Discount" };
            }
            return coupon;
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            var connection = new NpgsqlConnection(_configuration.GetConnectionString("DiscountDB"));
            var affected = await connection.ExecuteAsync("UPDATE Coupon SET ProductId=@ProductId,ProductName=@ProductName,Description=@Description,Amount=@Amount", new { ProductId = coupon.ProductId, ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount });
            if (affected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
