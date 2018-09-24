using AutoMapper;
using SkeletonDotNetCore.WebAPI.Core.Resources;
using SkeletonDotNetCore.WebAPI.Core.Models;
using SkeletonDotNetCore.WebAPI.Extensions;

namespace SkeletonDotNetCore.WebAPI.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateValueResource, Value>();
            CreateMap<UpdateValueResource, Value>();
            CreateMap<Value, ValueResource>()
                .ForMember(dest => dest.Timestamp, opt => {
                    opt.MapFrom(src => src.DateCreated.Timestamp());
                });
        }
    }
}