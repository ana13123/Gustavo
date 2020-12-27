using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProyect.Models
{
    public class CreateViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public string Author { get; set; }
        [Required]
        public IFormFile PhotoLink { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
