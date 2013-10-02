using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkiSchool.Web.Models;
using SkiSchool.Web.RestHelpers;

namespace SkiSchool.Web.Controllers.Api
{
    public class EmployeesController : ApiController
    {

        public readonly string _clientToken = @"578DB399-7047-4E82-921D-DA51E8F14A4E";

        // GET api/employees/5
        public Employee Get(int? loginId, int? id)
        {
            HttpStatusCode httpStatusCode;

            if (id == null)
            {
                var employeeWithLoginIdUrl = string.Format(@"http://employeeapi.resortdataservices.com/api/employees/0?loginId={0}&clienttoken={1}", loginId, _clientToken);

                var employeeWithLoginIdUri = new Uri(employeeWithLoginIdUrl);

                var employee = Invoke.Get<Employee>(employeeWithLoginIdUri, out httpStatusCode);

                return employee;
            }

            if (loginId == null)
            {
                var employeeWithIdUrl = string.Format(@"http://employeeapi.resortdataservices.com/api/employees/{0}?loginId=&clienttoken={1}", id, _clientToken);

                var employeeWithIdUri = new Uri(employeeWithIdUrl);

                var employee = Invoke.Get<Employee>(employeeWithIdUri, out httpStatusCode);

                return employee;
            }

            return new Employee();
        }
    }
}
