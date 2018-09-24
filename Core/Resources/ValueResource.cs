using System;

namespace SkeletonDotNetCore.WebAPI.Core.Resources
{
    public class ValueResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public long Timestamp { get; set; }
    }
}