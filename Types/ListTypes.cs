using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class ListTypes
    {
    }
    public interface ICategories
    {
        int categoryID { get; set; }
        string categoryName { get; set; }
        string description { get; set; }
        DateTime createdDate { get; set; }
    }
    public interface IJokes
    {
        int id { get; set; }
        string title { get; set; }
        string teaser { get; set; }
        string joke_text { get; set; }
        DateTime created_at { get; set; }
        int user_id { get; set; }
        int category_id { get; set; }
        bool featured { get; set; }
    }
    public interface IUsers
    {
        int id { get; set; }
        string first_name { get; set; }
        string last_name { get; set; }
        string emailAddress { get; set; }
        string username { get; set; }
        string password { get; set; }
        DateTime created_at { get; set; }
        DateTime last_login { get; set; }
        string avatar { get; set; }
    }


    public struct Parms
    {
        public string name;
        public object value;
        public ParameterDirection direction;
        public SqlDbType datatype;
        public int size;
        public Parms(string tempName, object tempValue, ParameterDirection tempDirection, SqlDbType tempDatatype, int tempSize = 0)
        {
            this.name = tempName;
            this.value = tempValue;
            this.direction = tempDirection;
            this.datatype = tempDatatype;
            this.size = tempSize;
        }
    }
}
