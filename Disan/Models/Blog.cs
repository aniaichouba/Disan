using System;

namespace Disan.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitele { get; set; }    
        public string BlogDesc { get; set; }
        public string BlogImg { get; set; }
        public DateTime PublishDate { get; set; }   
        public bool IsPublished { get; set; }
    }
}
