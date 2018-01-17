using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DAL
{
    public sealed class DataAccessLayer
    {
        private DataAccessLayer() { }

        #region "DataAccess"

        public static DataTable GetDataTable(string SQLStatement, List<Parms> ParmsList = null)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = CreateCommandObject(SQLStatement, ParmsList);
            da.Fill(dt);
            return dt;
        }

        public static DataSet GetDataSet(string SQLStatement, List<Parms> ParmsList = null)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = CreateCommandObject(SQLStatement, ParmsList);
            da.Fill(ds);
            return ds;
        }

        public static int SendData(string SQLStatement, List<Parms> ParmsList = null)
        {
            SqlCommand cmd = CreateCommandObject(SQLStatement, ParmsList);
            using (cmd.Connection)
            {
                cmd.Connection.Open();
                int returnValue = cmd.ExecuteNonQuery();
                UnloadParms(ParmsList, cmd);
                cmd.Connection.Close();
                return returnValue;
            }
        }

        private static void UnloadParms(List<Parms> parms, SqlCommand cmd)
        {
            if (parms != null)
            {
                for (int i = 0; i < parms.Count - 1; i++)
                {
                    Parms p = parms[i];
                    p.value = cmd.Parameters[i].Value;
                    parms[i] = p;
                }
            }
        }

        #endregion

        #region Make And Load Command Object
        private static SqlCommand CreateCommandObject(string SQLStatement, List<Parms> ParmsList)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SQLStatement;
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            if (ParmsList != null)
            {
                foreach (Parms p in ParmsList)
                {
                    cmd.Parameters.Add(new SqlParameter(p.name, p.datatype, p.size));
                    cmd.Parameters[p.name].Value = p.value;
                    cmd.Parameters[p.name].Direction = p.direction;
                    cmd.Parameters[p.name].Size = p.size;
                }
            }
            return cmd;

        }
        #endregion
    }
}
