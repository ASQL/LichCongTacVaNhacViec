using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScheduleDAL
    {
        public bool AcceptWork(String staffID, String notificationID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaCanBo",staffID),
                new SqlParameter("@MaThongBao",notificationID)
            };
            return DBConnection.Instance.ExecuteQuery("AcceptWork", parameters, CommandType.StoredProcedure);
        }
    }
}
