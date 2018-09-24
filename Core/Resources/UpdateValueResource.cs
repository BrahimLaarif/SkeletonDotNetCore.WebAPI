using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.Core.Resources
{
    public class UpdateValueResource
    {
        [Required]
        public string Name { get; set; }
    }
}