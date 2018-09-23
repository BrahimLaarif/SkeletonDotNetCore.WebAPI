using AutoMapper;
using SkeletonDotNetCore.WebAPI.DTOs;
using SkeletonDotNetCore.WebAPI.Models;

namespace SkeletonDotNetCore.WebAPI.Helpers
{
    public class SkeletonAutoMapperProfile : Profile
    {
        public SkeletonAutoMapperProfile()
        {
            CreateMap<AddValueDTO, Value>();
            CreateMap<EditValueDTO, Value>();
            CreateMap<Value, ViewValueDTO>()
                .ForMember(dest => dest.Timestamp, opt => {
                    opt.MapFrom(src => src.DateCreated.CalculateTimestamp());
                });
        }
    }
}