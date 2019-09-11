using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.Domain.Entities
{
    public class Post : BaseEntity
    {
        public int AutherId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        // Navigation property 
        public User Auther { get; set; }
        public Category Category { get; set; }

    }
}
