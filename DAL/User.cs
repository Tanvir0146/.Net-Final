//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Comments = new HashSet<Comment>();
            this.News = new HashSet<News>();
            this.news_reacts = new HashSet<news_reacts>();
        }
    
        public int id { get; set; }
        public string full_name { get; set; }
        public string user_name { get; set; }
        public Nullable<int> type { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<news_reacts> news_reacts { get; set; }
        public virtual Role Role { get; set; }
    }
}
