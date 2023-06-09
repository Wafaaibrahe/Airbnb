﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.Models
{
    public partial class Image
    {
        [Key]
        public int ImgId { get; set; }
        [Required]
        public string img { get; set; }
        public int? hotel_id { get; set; }

        [ForeignKey("hotel_id")]
        [InverseProperty("Images")]
        public virtual Hotel hotel { get; set; }
    }
}