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

        public DataTable GetAllBus()
        {
            return scheduleDAL.GetAll();
        }

        public bool InsertBus(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate, String facultyId, String subjectId)
        {
            return scheduleDAL.Insert(scheduleId, work, detail, place, beginDate, endDate, facultyId, subjectId);
        }

        public bool UpdateBus(String scheduleId, String work, String detail, String place, DateTime beginDate, DateTime endDate, String facultyId, String subjectId)
        {
            return scheduleDAL.Update(scheduleId, work, detail, place, beginDate, endDate, facultyId, subjectId);
        }
        public bool Delete(string scheduleId)
        {
            return scheduleDAL.Delete(scheduleId);
        }


        public DataTable findScheduleByWorkBus(String work)
        {
            return scheduleDAL.findSchedulebyWork(work);
        }

        public string getLastIdBus()
        {
            return scheduleDAL.getLastId();
        }
        public string getLastIdNotiBus()
        {
            return scheduleDAL.getLastIdNoti();
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

        public bool InsertNotification(string staffId, string notiId, string scheId, DateTime sendTime, DateTime endTime, int soLan)
        {
            return scheduleDAL.InsertNotification(staffId, notiId, scheId, sendTime, endTime, soLan);
        }
    }
}
