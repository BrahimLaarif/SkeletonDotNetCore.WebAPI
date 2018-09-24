using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.Core.Resources
{
    public class CreateValueResource
    {
        [Required]
        public string Name { get; set; }
    }
}