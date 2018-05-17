using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Display(Name = "Kod")]
        [DataType(DataType.MultilineText)]
        public string Code { get; set; }
        [Display(Name = "Programlama Dili")]
        public int LanguageId { get; set; }
        [Display(Name = "Programlama Dili")]
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
        
    }
}