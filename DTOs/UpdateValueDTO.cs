using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.DTOs
{
    public class UpdateValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}