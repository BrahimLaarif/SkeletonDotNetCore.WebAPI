using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.Core.DTOs
{
    public class CreateValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}