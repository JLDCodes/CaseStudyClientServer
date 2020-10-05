using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace HelpDeskDAL
{
    public class EmployeeDAO
    {

        public Employees GetByEmail(string email)
        {
            Employees selectedEmployee = null;

            try
            {
                HelpDeskContext _db = new HelpDeskContext();
                selectedEmployee = _db.Employees.FirstOrDefault(emp => emp.Email == email);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " +
                    MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw ex;
            }

            return selectedEmployee;
        }

    }
}
