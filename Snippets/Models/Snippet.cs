using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Snippets.Models
{
    public class Snippet
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Snipp Adı")]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Snipp Kodu")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Snipp Dili")]
        [StringLength(200)]
        public string Language { get; set; }
    }
}