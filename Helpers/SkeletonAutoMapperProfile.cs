using AutoMapper;
using SkeletonDotNetCore.WebAPI.DTOs;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Helpers
{
    public class SkeletonAutoMapperProfile : Profile
    {
        public SkeletonAutoMapperProfile()
        {
            CreateMap<CreateValueDTO, Value>();
            CreateMap<UpdateValueDTO, Value>();
            CreateMap<Value, ValueDTO>()
                .ForMember(dest => dest.Timestamp, opt => {
                    opt.MapFrom(src => src.DateCreated.CalculateTimestamp());
                });
        }
    }
}