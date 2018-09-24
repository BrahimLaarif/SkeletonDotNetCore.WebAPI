using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.DTOs
{
    public class CreateValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}