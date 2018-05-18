using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snippets.Models
{
    public class Category
    {
        public Category()
        {
            Snippets = new HashSet<Snippet>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Snippet> Snippets { get; set; }
    }
}