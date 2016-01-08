using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notification
    {
        private String id;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private String detail;

        public String Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        // 1: unread; 2: replied; 3: over times;
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime receiveTime;

        public DateTime ReceiveTime
        {
            get { return receiveTime; }
            set { receiveTime = value; }
        }

        private DateTime deadline;

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        private int times;

        public int Times
        {
            get { return times; }
            set { times = value; }
        }
        
    }
}
