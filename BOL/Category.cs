using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    class Category : Types.ICategories
    {
        internal int _categoryID;
        internal string _categoryName;
        internal string _description;
        internal DateTime _createdDate;

        // CATEGORY ID
        public int categoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }

        // CATEGORY NAME
        public string categoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        // DESCRIPTION
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        // CATEGORY CREATION DATE
        public DateTime createdDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }
    }
}
