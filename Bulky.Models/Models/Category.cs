﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id ")]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name ")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 30, ErrorMessage = "Here is an Error. Please check...")]
        public string DisplayOrder { get; set; }
    }
}
