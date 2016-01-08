using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FacultyBUS
    {
        private FacultyDAL facultyDAL;

        public FacultyBUS()
        {
            facultyDAL = new FacultyDAL();
        }

        public List<Faculty> GetList()
        {
            try
            {
                List<Faculty> faculties = new List<Faculty>();
                DataTable dt = facultyDAL.GetAll();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    Faculty faculty = new Faculty();
                    faculty.ID = dt.Rows[i][0].ToString();
                    faculty.Name = dt.Rows[i][1].ToString();
                    faculties.Add(faculty);
                }
                return faculties;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
