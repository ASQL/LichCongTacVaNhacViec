using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacultyDAL
    {
        public DataTable GetAll()
        {
            return DBConnection.Instance.ExecuteSelectQuery("select * from Khoa", null, CommandType.Text);
        }
        
    }
}
