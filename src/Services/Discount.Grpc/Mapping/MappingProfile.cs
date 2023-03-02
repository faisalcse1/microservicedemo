using AutoMapper;
using Discount.Grpc.Models;
using Discount.Grpc.Protos;

namespace Discount.Grpc.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        { 
            CreateMap<Coupon,CouponRequest>().ReverseMap();
        }
    }
}
