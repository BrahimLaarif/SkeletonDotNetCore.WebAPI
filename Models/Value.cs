using System;
using System.ComponentModel.DataAnnotations;

namespace SkeletonDotNetCore.WebAPI.Models
{
    public class Value
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public Value()
        {
            DateCreated = DateTime.Now;
        }
    }
}