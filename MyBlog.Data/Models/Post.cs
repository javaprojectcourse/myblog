using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Data.Models
{
    public class Post
    {
        public int id { get; set; }

        public Blog Blog { get; set; }

        public ApplicationUser Poster { get; set; }

        public Post Parent { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
