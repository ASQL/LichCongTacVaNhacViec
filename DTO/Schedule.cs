using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Schedule
    {
        private String id;

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        private String work;

        public String Work
        {
            get { return work; }
            set { work = value; }
        }

        private String detail;

        public String Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        private String place;

        public String Place
        {
            get { return place; }
            set { place = value; }
        }

        private DateTime beginDate;

        public DateTime BeginDate
        {
            get { return beginDate; }
            set { beginDate = value; }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
