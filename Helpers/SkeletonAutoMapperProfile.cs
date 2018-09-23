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
        }
    }
}