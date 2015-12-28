using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NotificationDAL
    {
        public DataTable GetLastTenRowsByStaffID(String id)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@ID",id)
            };
            return DBConnection.Instance.ExecuteSelectQuery("GetLastTenRowsByStaffID", parameters, CommandType.StoredProcedure);
        }
    }
}
