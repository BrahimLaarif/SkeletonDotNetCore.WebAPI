using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkeletonDotNetCore.WebAPI.Models
{
    [Table("Values")]
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