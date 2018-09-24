using AutoMapper;
using SkeletonDotNetCore.WebAPI.DTOs;
using SkeletonDotNetCore.WebAPI.Core.Models;

namespace SkeletonDotNetCore.WebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
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