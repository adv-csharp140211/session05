﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace App05.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public string Description { get; set; }

    //Navigation Peoperty
    public ICollection<Product> Products { get; set; }
}