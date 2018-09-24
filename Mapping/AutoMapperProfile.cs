using AutoMapper;
using SkeletonDotNetCore.WebAPI.Core.DTOs;
using SkeletonDotNetCore.WebAPI.Core.Models;
using SkeletonDotNetCore.WebAPI.Extensions;

namespace SkeletonDotNetCore.WebAPI.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateValueDTO, Value>();
            CreateMap<UpdateValueDTO, Value>();
            CreateMap<Value, ValueDTO>()
                .ForMember(dest => dest.Timestamp, opt => {
                    opt.MapFrom(src => src.DateCreated.Timestamp());
                });
        }
    }
}