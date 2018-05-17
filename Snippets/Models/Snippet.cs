﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snippets.Models
{
    public class Snippet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Language { get; set; }
    }
}