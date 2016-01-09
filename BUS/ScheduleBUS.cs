using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ScheduleBUS
    {
        private ScheduleDAL scheduleDAL;

        public ScheduleBUS()
        {
            scheduleDAL = new ScheduleDAL();
        }

        public bool AcceptWork(String staffID, String notificationID)
        {
            try
            {
                return scheduleDAL.AcceptWork(staffID, notificationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RejectWork(String staffID, String notificationID)
        {
            try
            {
                return scheduleDAL.RejectWork(staffID, notificationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetAllBus()
        {
            return scheduleDAL.GetAll();
        }

        public bool InsertBus(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate, String facultyId, String subjectId)
        {
            return scheduleDAL.Insert(scheduleId, work, detail, place, beginDate, endDate, facultyId, subjectId);
        }

        public bool UpdateBus(Schedule schedule )
        {
            return scheduleDAL.Update(schedule);
        }
        //public bool Delete()


        public DataTable findScheduleByWorkBus(String work)
        {
            return scheduleDAL.findSchedulebyWork(work);
        }

        public string getLastIdBus()
        {
            return scheduleDAL.getLastId();
        }

        public string getFacultyId(string staffId)
        {
            return scheduleDAL.getFacultyId(staffId);
        }

        public string getSubjectId(string staffId)
        {
            return scheduleDAL.getSubjectId(staffId);
        }
        public DataTable getStaffInSubject(string staffId)
        {
            return scheduleDAL.getStaffinSubject(staffId);
        }
        public DataTable getStaffInFaculty(string faculty)
        {
            return scheduleDAL.getStaffinFaculty(faculty);
        }
    }
}
