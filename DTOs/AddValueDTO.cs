using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.DTOs
{
    public class AddValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}