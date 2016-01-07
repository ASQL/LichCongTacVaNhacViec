using DAL;
using System;
using System.Collections.Generic;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
