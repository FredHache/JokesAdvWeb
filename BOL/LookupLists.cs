using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{

    // JOKE
    public class JokeLookupList
    {
        internal JokeLookupList() { }

        public int id { get; internal set; }
        public string title { get; internal set; }
        public string teaser { get; internal set; }
        public string joke_text { get; internal set; }
        public DateTime created_at { get; internal set; }
        public int user_id { get; internal set; }
        public int category_id { get; internal set; }
        public bool featured { get; internal set; }
    }

    // CATEGORY
    public class CategoryLookupList
    {
        internal CategoryLookupList() { }
        
        public int categoryID { get; internal set; }
        public string categoryName { get; internal set; }
        public string description { get; internal set; }
        public DateTime createdDate { get; internal set; }
    }

    // USER
    public class UserLookupList
    {
        internal UserLookupList() { }

        public int id { get; internal set; }
        public string first_name { get; internal set; }
        public string last_name { get; internal set; }
        public string emailAddress { get; internal set; }
        public string username { get; internal set; }
        public string password { get; internal set; }
        public DateTime created_at { get; internal set; }
        public DateTime last_login { get; internal set; }
        public string avatar { get; internal set; }
    }
}
