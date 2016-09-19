﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookServiceKnockoutJS.DTO
{
    public class BookDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
    }
}