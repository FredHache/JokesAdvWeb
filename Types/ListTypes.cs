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
