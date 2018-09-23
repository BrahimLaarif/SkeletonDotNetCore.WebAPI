using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.DTOs
{
    public class EditValueDTO
    {
        [Required]
        public string Name { get; set; }
    }
}