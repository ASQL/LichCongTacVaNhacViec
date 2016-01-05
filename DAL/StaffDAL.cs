using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffDAL
    {
        public DataTable GetStaffByAccount(String account)
        {
            SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Account", account)
            };
            return DBConnection.Instance.ExecuteSelectQuery("GetStaffByAccount", sqlParams, CommandType.StoredProcedure);
        }

        public bool UpdatePassword(String account, String password)
        {
            SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Account",account),
                new SqlParameter("@Password",password)
            };
            return DBConnection.Instance.ExecuteQuery("update TaiKhoan set MatKhau=@Password where TenTaiKhoan=@Account", sqlParams, CommandType.Text);
        }
    }
}
