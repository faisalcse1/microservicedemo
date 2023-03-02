using AutoMapper;
using Discount.Grpc.Models;
using Discount.Grpc.Protos;
using Discount.Grpc.Repository;
using Grpc.Core;

namespace Discount.Grpc.Services
{
    public class DiscountService:DiscountProtoService.DiscountProtoServiceBase
    {
        ICouponRepositroy _couponRepository;
        ILogger<DiscountService> _logger;
        IMapper _mapper;
        public DiscountService(ICouponRepositroy couponRepositroy,ILogger<DiscountService>logger,IMapper mapper) 
        { 
            _couponRepository= couponRepositroy;
            _logger= logger;
            _mapper= mapper;
        }

        public override async Task<CouponRequest> GetDiscount(GetDiscountRequest request, ServerCallContext context)
        {
            var coupon = await _couponRepository.GetDiscount(request.ProductId);
            if(coupon==null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Discount not found."));
            }
            _logger.LogInformation("Discount is retrived for ProductName :{productName},Amount : {amount}",coupon.ProductName,coupon.Amount);
            //return new CouponRequest { ProductId = coupon.ProductId, ProductName = coupon.ProductName, Description = coupon.Description, Amount = coupon.Amount };
            return _mapper.Map<CouponRequest>(coupon);
        }

        public override async Task<CouponRequest> CreateDiscount(CouponRequest request, ServerCallContext context)
        {
            var coupon = _mapper.Map<Coupon>(request);
            bool isSaved = await _couponRepository.CreateDiscount(coupon);
            if(isSaved)
            {
                _logger.LogInformation("Discount is successfully created. ProductName :{ProductName}", coupon.ProductName);
            }
            else
            {
                _logger.LogInformation("Discount created failed.");
            }
            
            return _mapper.Map<CouponRequest>(coupon);
        }

        public override async Task<CouponRequest> UpdateDiscount(CouponRequest request, ServerCallContext context)
        {
            var coupon= _mapper.Map<Coupon>(request);
            bool IsModified=await _couponRepository.UpdateDiscount(coupon);
            if(IsModified)
            {
                _logger.LogInformation("Discount is successfully updated. ProductName : {ProductName}", coupon.ProductName);
            }
            else
            {
                _logger.LogInformation("Discount update failed.");
            }            
            return _mapper.Map<CouponRequest>(coupon);
        }

        public override async Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
        {
            bool isDeleted = await _couponRepository.DeleteDiscount(request.ProductId);
            if(isDeleted)
            {
                _logger.LogInformation("Discount has been deleted. ProductName :{ProductId}", request.ProductId);

            }
            else
            {
                _logger.LogInformation("Discount deleted failed.");
            }
            return new DeleteDiscountResponse() { Success = isDeleted };

        }

    }
}
