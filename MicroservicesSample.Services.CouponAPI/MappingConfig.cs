using AutoMapper;
using MicroservicesSample.Services.CouponAPI.Models;
using MicroservicesSample.Services.CouponAPI.Models.Dto;
namespace MicroservicesSample.Services.CouponAPI
    
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
