//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WallPostByTechBrij.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.PostComments = new HashSet<PostComment>();
        }
    
        public int PostId { get; set; }
        public string Message { get; set; }
        public int PostedBy { get; set; }
        public System.DateTime PostedDate { get; set; }
    
        public virtual ICollection<PostComment> PostComments { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
