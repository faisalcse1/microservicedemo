using Discount.Grpc.Protos;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        public readonly DiscountProtoService.DiscountProtoServiceClient _discountService;
        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountService)
        {
            _discountService= discountService;
        }

        public async Task<CouponRequest>GetDiscount(string productId)
        {
            var getDisCountData =new  GetDiscountRequest(){ ProductId=productId};
            return await _discountService.GetDiscountAsync(getDisCountData);
        }
    }
}
