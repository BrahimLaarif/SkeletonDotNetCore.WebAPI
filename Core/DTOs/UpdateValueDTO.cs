using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.Core.DTOs
{
    public class UpdateValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}