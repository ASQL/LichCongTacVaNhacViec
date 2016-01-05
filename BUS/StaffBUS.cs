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
    public class StaffBUS
    {
        private StaffDAL staffDAL;

        public StaffBUS()
        {
            staffDAL = new StaffDAL();
        }

        public Staff GetStaffByAccount(String account)
        {
            try
            {
                Staff staff = new Staff();
                DataTable dt = staffDAL.GetStaffByAccount(account);
                if (dt.Rows.Count <= 0)
                {
                    throw new Exception("Tài khoản không tồn tại!");
                }
                else
                {
                    staff.ID = dt.Rows[0][0].ToString();
                    staff.Name = dt.Rows[0][1].ToString();
                    staff.Sex = dt.Rows[0][2].ToString();
                    staff.Birthday = Convert.ToDateTime(dt.Rows[0][3].ToString());
                    staff.Email = dt.Rows[0][4].ToString();
                    staff.PhoneNumber = dt.Rows[0][5].ToString();
                    staff.Address = dt.Rows[0][6].ToString();
                    staff.Subject = dt.Rows[0][7].ToString();
                    staff.Account = dt.Rows[0][8].ToString();
                    staff.Password = dt.Rows[0][9].ToString();
                    if (dt.Rows[0][10].ToString().Equals("Admin"))
                    {
                        staff.Type = 1;
                    }
                    else
                    {
                        if (dt.Rows[0][10].ToString().Equals("Chủ nhiệm khoa"))
                        {
                            staff.Type = 2;
                        }
                        else
                        {
                            if (dt.Rows[0][10].ToString().Equals("Chủ nhiệm bộ môn"))
                            {
                                staff.Type = 3;
                            }
                            else
                            {
                                staff.Type = 4;
                            }
                        }
                    }
                    staff.Faculty = dt.Rows[0][11].ToString();
                    return staff;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdatePassword(String account, String password)
        {
            return staffDAL.UpdatePassword(account, password);
        }
    }
}
