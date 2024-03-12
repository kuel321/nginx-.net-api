// File: Image.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace ImageGalleryApi.Models
{
    public class Image
    {
        [Key]
        public Guid ImageID { get; set; }
        
        // Resolve CS8618 warning: Initialize properties or make them nullable
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        
        // You may also want to initialize DateTime properties
        public DateTime UploadDate { get; set; } = DateTime.Now;
    }
}
