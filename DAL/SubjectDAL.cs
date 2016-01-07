using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectDAL
    {
        public DataTable GetAll()
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from BoMon", null, CommandType.Text);
        }

        public DataTable GetSubjectByFaculty(String FacultyID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MaKhoa",FacultyID)
            };
            return DBConnection.Instance.ExecuteSelectQuery("select * from BoMon where MaKhoa = @MaKhoa", parameters, CommandType.Text);
        }
    }
}
