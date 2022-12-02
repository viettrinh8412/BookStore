﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
