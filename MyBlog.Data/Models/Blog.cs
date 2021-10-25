using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Data.Models
{
    public class Blog
    {
        public int id { get; set; }

        public ApplicationUser Creator { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool Published { get; set; }

        public bool Approved { get; set; }

        public bool Approver { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
