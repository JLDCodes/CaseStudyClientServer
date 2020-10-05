using Xunit;
using HelpDeskDAL;
using System.Collections.Generic;
using NuGet.Frameworks;


namespace CaseStudyTests
{
    public class DAOTests
    {
        [Fact]
        public void Employee_GetByEmail()
        {
            EmployeeDAO dao = new EmployeeDAO();
            Employees selectedEmployee = dao.GetByEmail("bs@abc.com");
            Assert.NotNull(selectedEmployee);

        }
    }
}
